using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class MasterBanks
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
        [AllowNull]
        public string BankLogo { get; set; }
        public bool isActive { get; set; }
    }
}
