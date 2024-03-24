using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MasterBankAccount
    {
        [Key]
        public int BankAccountId { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string BankLogo { get; set; }
        public bool IsActive { get; set; }
    }
}
