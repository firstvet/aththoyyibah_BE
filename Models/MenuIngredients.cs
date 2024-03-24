
using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MenuIngredients
    {

        [Key]
        public int MenuIngredientId { get; set; }
        public int MenuId { get; set; }
        public int IngredientsId { get; set; }
        public int Quantity { get; set; } = 0;
        public int UomId { get; set; }
        public string? LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
