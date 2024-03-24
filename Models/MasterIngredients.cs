using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class MasterIngredients
    {
        [Key]
        public int IngredientsId { get; set; }
        public string Name { get; set; }
        public string UOM { get; set; }
        public int QTY { get; set; }
        public bool isActive { get; set; }
        public string Remarks { get; set; }
        [AllowNull]
        public string RequestBy { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
        public int? IngridientCategoryId { get; set; }
    }
}
