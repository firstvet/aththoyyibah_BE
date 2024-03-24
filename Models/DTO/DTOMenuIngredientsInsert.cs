
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class DTOMenuIngredientsInsert
    {
        public int MenuId { get; set; }
        public int IngredientsId { get; set; }
        [AllowNull]
        public string? OtherIngridients { get; set; }
        [AllowNull]
        public string? note { get; set; }
        public int Quantity { get; set; } = 0;
        public int UomId { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
