using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOReferalBonusClaim
    {
        public int UserId { get; set; }
        public Int64 ClaimedAmount { get; set; }
        public DateTime ClaimDate { get; set; }
        public string BankTransfer { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Status { get; set; }
    }
}
