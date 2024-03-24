using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class SubcriptionEvidences
    {
        [Key]
        public int SubcriptionEvidenceId { get; set; }
        public string? userEmail { get; set; }
        public string? transferBy { get; set; }
        public int subsPeriodId { get; set; }
        [AllowNull]
        public string? evidenceURL { get; set; }
        [AllowNull]
        public string? evidenceFile { get; set; }
        [AllowNull]
        public string? evidenceBase64 { get; set; }
        public bool isValid { get; set; }
        public DateTime? transferDate { get; set; }
        [AllowNull]
        public DateTime? activateDate { get; set; }
    }
}
