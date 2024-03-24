using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTORejectSubcription
    {
        public int userId { get; set; }
        [AllowNull]
        public string remarks { get; set; } = null;
    }
}
