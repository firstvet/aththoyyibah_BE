namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOMenuIngredients : MenuIngredients
    {
        public List<MasterIngredients> MasterIngredientsList { get; set; }
        public int MenuIngredientId { get; set; }
        public string MenuName { get; set; }
        public string IngredientsName { get; set; }
        public bool isIngActive { get; set; }
        public string Uom { get; set; }
        public int Quantity { get; set; }

        public string IngridientCategoryName { get; set; }
        public int IngridientCategoryId { get; set; }


    }
}
