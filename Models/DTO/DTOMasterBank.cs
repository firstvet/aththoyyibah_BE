using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOMasterBank
    {
        public string BankName { get; set; }
        [AllowNull]
        public IFormFile BankLogo { get; set; }
    }
}
