namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUserResetPassword
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string latestPassword { get; set; }
        public string newPassword { get; set; }
        //public string? referalCode { get; set; } = null;
        //public int subscriptionId { get; set; }
        //public int subsPeriodId { get; set; }
    }
}
