using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOInsertMasterIngredients
    {
        public string Name { get; set; }
        public string? UOM { get; set; }
        public int QTY { get; set; }
        public int? IngredientsCategoryId { get; set; }
        public bool isActive { get; set; }
        public string? Remarks { get; set; }
        [AllowNull]
        public string? RequestBy { get; set; }
        public int LMBY { get; set; }
        public DateTime? LMDT { get; set; }
    }
}
