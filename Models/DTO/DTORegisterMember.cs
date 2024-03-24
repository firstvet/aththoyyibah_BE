using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTORegisterMember
    {
        public string name { get; set; }

        [AllowNull]
        public string userName { get; set; }

        [AllowNull]
        public string password { get; set; }

        [AllowNull]
        public string phoneNumber { get; set; }
        //public string education { get; set; }
        //public DateTime birthDate { get; set; }
        //public string address { get; set; }
        //public IFormFile photoMember { get; set; }
        public bool isActive { get; set; }
        public int userId { get; set; }
        [AllowNull]
        public string lmby { get; set; }
        [AllowNull]
        public DateTime lmdt { get; set; }
    }
}
