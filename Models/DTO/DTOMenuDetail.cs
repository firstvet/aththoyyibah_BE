namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOMenuDetail
    {
        public Menus menuById { get; set; }
        public List<DTOMenuIngredients> menuIng { get; set; }
    }
}
