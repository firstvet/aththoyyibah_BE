using Ath_Thoyyibah_BE.Models.DTO;

namespace Ath_Thoyyibah_BE.Services.AuthService
{
    public interface IAuthService
    {
        Task<Response> Register(DTOUserRegister user, Response response);
        Task<Response> Login(UserLogin user, Response response);
        
    }
}
