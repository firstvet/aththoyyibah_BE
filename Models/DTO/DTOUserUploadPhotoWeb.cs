namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUserUploadPhotoWeb
    {
        public int userId { get; set; }
        public IFormFile photoFile { get; set; }
        //public string? referalCode { get; set; } = null;
        //public int subscriptionId { get; set; }
        //public int subsPeriodId { get; set; }
    }
}
