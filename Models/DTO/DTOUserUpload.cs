namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUserUpload
    {
        public int userId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? sex { get; set; }
        public string? education { get; set; }
        public DateTime? dateofBirth { get; set; }
    }
}
