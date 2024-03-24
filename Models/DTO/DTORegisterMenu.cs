using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTORegisterMenu
    {
        public string MenuName { get; set; }
        public string Description { get; set; }

        [AllowNull]
        public string? Note { get; set; }

        [AllowNull]
        public IFormFile PhotoFile { get; set; }
        [AllowNull]
        public IFormFile VideoFile { get; set; }
        public bool IsPublished { get; set; }
        public string LMBY { get; set; }
        [AllowNull]
        public DateTime LMDT { get; set; }
        public int CreatedBy { get; set; }
    }
}
