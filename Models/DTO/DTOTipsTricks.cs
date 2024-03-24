namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOTipsTricks
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile VideoFile { get; set; }
        public int CreatedBy { get; set; }

    }
}
