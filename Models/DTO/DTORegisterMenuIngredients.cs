namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTORegisterMenuIngredients
    {
        public Menus InsertedMenu { get; set; }
        public List<DTOGetIngridientsCategory> MasterIngredientsList { get; set; }
        public List<MasterUoms> MasterUomsList { get; set; }
        public List<DTOMenuIngredients> RegisteredIngredients { get; set; }
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int IngredientsId { get; set; }
        public int Quantity { get; set; }
        public bool AblePublish { get; set; }

    }
}
