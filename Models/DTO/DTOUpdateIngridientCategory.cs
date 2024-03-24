namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUpdateIngridientCategory
    {
        public int IngridientCategoryId { get; set; }
        public string IngridientCategoryName { get; set; }
        public bool IsActive { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDTT { get; set; }
    }
}
