using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class ReferalBonusClaim
    {
        [Key]
        public int ReferalBonusClaimId { get; set; }
        public int UserId { get; set; }
        public Int64 ClaimedAmount { get; set; }
        public DateTime ClaimDate { get; set; }
        public DateTime ApprovedDate { get; set; }
        public DateTime TransferDate { get; set; }
        public string BankTransfer { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string TransferEvidence { get; set; }
    }
}
