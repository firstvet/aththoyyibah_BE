namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOPagination
    {
        public int pageSize { get; set; }
        public int currentPage { get; set; }
        public bool isPhoto { get; set; }
        public bool isVideo { get; set; }
        public bool status { get; set; } = true;
        public int userId { get; set; }
        public string? keyword { get; set; } = "";
    }
}
