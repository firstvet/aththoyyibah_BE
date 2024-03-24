using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOSubscriptionEvidenceMobile
    {
        [AllowNull]
        public List<MasterBankAccount>? MasterBankAccounts { get; set; }
        //public int subscriptionEvidenceId { get; set; }
        public string evidenceFile { get; set; }
        public string email { get; set; }
        public int subscriptionPeriodId { get; set; }
        [AllowNull]
        public string? transferBy { get; set; } = null;
        public int selectedBankId { get; set; }
    }
}
