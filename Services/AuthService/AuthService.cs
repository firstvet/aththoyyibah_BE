using Ath_Thoyyibah_BE.Data;
using Ath_Thoyyibah_BE.Models;
using Ath_Thoyyibah_BE.Models.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using NuGet.Common;
using NuGet.Protocol;
using RestSharp;
using RestSharp.Authenticators;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Json;

namespace Ath_Thoyyibah_BE.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        string photoProfileVPath;
        string photoProfilePath;
        string MTAPIKeyServer;
        string MTAPIKeyClient;
        string MTAPISandURL;
        string MTAPILiveURL;
        public AuthService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

            photoProfileVPath = _configuration.GetValue<string>("PathSettings:photoProfileVPath");
            photoProfilePath = _configuration.GetValue<string>("PathSettings:photoProfilePath");
            MTAPIKeyServer = _configuration.GetValue<string>("Midtrans:ServerKey");
            MTAPIKeyClient = _configuration.GetValue<string>("Midtrans:ClientKey");
            MTAPISandURL = _configuration.GetValue<string>("Midtrans:SandboxAPI");
            MTAPILiveURL = _configuration.GetValue<string>("Midtrans:LiveAPI");
        }

        public class MidtransResponse
        {
            public string token { get; set; }
            public string redirect_url { get; set; }
        }
        private async Task<string> WriteFile(string emails, IFormFile fileUpload)
        {
            bool isSaveSuccess = false;
            string strErrMessage = string.Empty;
            var ext = "." + fileUpload.FileName.Split('.')[fileUpload.FileName.Split('.').Length - 1];
            string Filename = string.Empty;
            string FilePath = string.Empty;
            string vFilePath = string.Empty;
            string email = emails;
            try
            {

                //var ext = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                string rootPath = Path.Combine(photoProfilePath, email);
                string vRootPath = emails;
                Filename = Path.GetFileNameWithoutExtension(fileUpload.FileName) + "_" + String.Format("{0:ddMMyyyhhmm}", DateTime.Now) + ext;
                FilePath = Path.Combine(rootPath, Path.GetFileNameWithoutExtension(fileUpload.FileName) + "_" + String.Format("{0:ddMMyyyhhmm}", DateTime.Now)) + ext;
                vFilePath = Path.Combine(vRootPath, Path.GetFileNameWithoutExtension(fileUpload.FileName) + "_" + String.Format("{0:ddMMyyyhhmm}", DateTime.Now)) + ext;

                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                var filePath = Path.Combine(FilePath);
                if (fileUpload.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await fileUpload.CopyToAsync(stream);
                        isSaveSuccess = true;
                    }
                }
                else
                {
                    isSaveSuccess = false;
                }
            }
            catch (Exception ex)
            {
                strErrMessage = ex.Message;
                isSaveSuccess = false;
            }

            if (isSaveSuccess)
            {
                return vFilePath;
                //data.DocPath = vFilePath;
                //data.OriDocPath = vFilePath;
                //data.AttachmentName = Filename;
                //data.LMBY = GetToken().uid;
                //if (!await new BOL_ATPAttachment().ATPAttachmentUpload(data))
                //    return new JsonResult(new TransStatus(CommonConfig.MessageStatus_Error, "Evidence " + data.DocPath + " uploaded failed, please try again"));
                //else
                //    return new JsonResult(new TransStatus(CommonConfig.MessageStatus_Success, "Evidence " + data.DocPath + " uploaded successfully"));
            }
            else
            {
                return "filesave error";//new JsonResult(new TransStatus(CommonConfig.MessageStatus_Error, "Evidence " + data.DocPath + " uploaded failed, please try again"));
            }

        }

        private string CreateToken(UserLogin user)
        {
            var userlogin = _context.Users.Where(x => x.email == user.userName)
                .FirstOrDefault();
            if (userlogin.firstName == null)
            {
                userlogin.firstName = "";
            }
            if (userlogin.lastName == null)
            {
                userlogin.lastName = "";
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.userName),
                new Claim("UserName", user.userName),
                new Claim("Email", user.userName),
                new Claim("FirstName", userlogin.firstName),
                new Claim("LastName", userlogin.lastName),
                new Claim("UserId", userlogin.userId.ToString()),
                new Claim("RoleId", userlogin.roleId.ToString()),
                new Claim(JwtRegisteredClaimNames.Name,user.userName),
                new Claim(JwtRegisteredClaimNames.AuthTime, DateTime.Now.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ValueStorage.tokenKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: cred
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public async Task<Response> Login(UserLogin user, Response response)
        {
            
            string token = CreateToken(user);

            if (!token.IsNullOrEmpty())
            {
                response.code = "200";
                response.message = "Login Berhasil";
                response.responseTime = DateTime.Now;
                response.data = token;
                return response;

            }

            response.code = "500";
            response.message = "JWT token unsuccessful generated";
            response.responseTime = DateTime.Now;
            response.data = user;

            response.data = token;
            return response;


        }

        public async Task<Response> Register(DTOUserRegister user, Response response)
        {

            if (user.email == "" || user.email.IsNullOrEmpty() || user.password.IsNullOrEmpty())
            {
                response.code = "404";
                response.message = "Mohon Lengkapi Data";
                response.responseTime = DateTime.Now;
                response.data = user;

                return response;
            }

            var checkAva = await _context.Users.Where(c => c.email == user.email).ToListAsync();

            if (checkAva.Count > 0)
            {
                response.code = "500";
                response.message = "Email sudah pernah didaftarkan";
                response.responseTime = DateTime.Now;
                response.data = user;

                return response;
            }
            int userIdReferal = 0;
            if (!user.referalCode.IsNullOrEmpty())
            {
                var checkReferal = await _context.Users.Where(c => c.referalCode == (String.IsNullOrEmpty(user.referalCode) ? "" : user.referalCode)).ToListAsync();

                if (checkReferal == null || checkReferal.Count == 0)
                {
                    response.code = "404";
                    response.message = "Data Referal Tidak ditemukan";
                    response.responseTime = DateTime.Now;
                    response.data = user;

                    return response;
                }

                userIdReferal = checkReferal[0].userId;

            }

            string hashPassword = BCrypt.Net.BCrypt.HashPassword(user.password);

            ApplicationUser userRegister = new ApplicationUser
            {
                //firstName = user.firstName
                //, lastName = user.lastName
                email = user.email
                ,
                password = user.password
                ,
                passwordHash = hashPassword
                //, sex = user.sex
                //, dateofBirth = user.dateofBirth
                ,
                roleId = 2
                //, education = user.education
                ,
                lmdt = DateTime.Now
                ,
                RegisterDate = DateTime.Now
                //, subscriptionId = user.subscriptionId
            };

            bool result = _context.AddAsync(userRegister).IsCompletedSuccessfully;

            _context.SaveChanges();

            if (userIdReferal > 0)
            {
                UserReferals uref = new UserReferals
                {
                    userId = userIdReferal,
                    registeredUserId = userRegister.userId,
                    referalCode = user.referalCode,
                    lmby = userRegister.userId,
                    lmdt = DateTime.Now

                };
                bool resulturef = _context.AddAsync(uref).IsCompletedSuccessfully;

                _context.SaveChanges();

            }

            response.code = "200";
            response.message = ValueStorage.messageAddSuccess;
            response.responseTime = DateTime.Now;
            user.password = "************";
            response.data = _context.Users
                                  .Where(s => s.userId == userRegister.userId)
                                  .ToList(); ;

            return response;
        }


        public async Task<Response> GetUserDetailById(int userId, Response response)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                response.code = "200";
                response.message = "Login Berhasil";
                response.responseTime = DateTime.Now;
                response.data = user;
                return response;

            }

            response.code = "500";
            response.message = "JWT token unsuccessful generated";
            response.responseTime = DateTime.Now;

            response.data = user;
            return response;
        }

    }
}
