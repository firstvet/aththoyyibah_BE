using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class BankAccountUsers
    {
        [Key]
        public int BankAccountUsersId { get; set; }
        public int UserId { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public bool IsActive { get; set; }

    }
}
