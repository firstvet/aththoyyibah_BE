using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOGetIngridientsCategory
    {

        public int IngredientsId { get; set; }
        public string Name { get; set; }

        public bool isActive { get; set; }
        public string Remarks { get; set; }
        [AllowNull]
        public string RequestBy { get; set; }


        public int IngridientCategoryId { get; set; }
        [AllowNull]
        public string IngridientCategoryName { get; set; }
    }
}
