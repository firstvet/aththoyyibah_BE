namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUserUpdate
    {
        public int userId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? sex { get; set; }
        public string? education { get; set; }
        public DateTime? dateofBirth { get; set; }
        //public string? referalCode { get; set; } = null;
        //public int subscriptionId { get; set; }
        //public int subsPeriodId { get; set; }
    }
}
