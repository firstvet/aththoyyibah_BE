namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOMenuCategory
    {

        public int pageSize { get; set; }
        public int currentPage { get; set; }
        public bool status { get; set; } = true;
        public string? keyword { get; set; } = "";
        public string category { get; set; } = "";

    }
}
