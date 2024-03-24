using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class UserReferals
    {
        [Key]
        public int userReferalId { get; set; }
        public int userId { get; set; }
        public int registeredUserId { get; set; }
        public string referalCode { get; set; }
        public int referalUserBonus { get; set; }
        public int referalOwnerBonus { get; set; }
        public int lmby { get; set; }
        public DateTime lmdt { get; set; }
    }
}
