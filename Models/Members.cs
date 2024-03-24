using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class Members
    {
        [Key]
        public int memberId { get; set; }
        public string name { get; set; }
        public string userName { get; set; } = null;
        public string phoneNumber { get; set; } = null;
        public string password { get; set; } = null;
        public string? education { get; set; }
        public DateTime birthDate { get; set; }
        public string? address { get; set; }
        public string? photoBase64 { get; set; }
        public bool isActive { get; set; }
        public int userId { get; set; }
        public int pairingUserId { get; set; }
        public string? lmby { get; set; }
        public DateTime? lmdt { get; set; }

    }
}
