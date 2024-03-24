namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUpdatemasterPeriod
    {
        public int subscriptionPeriodId { get; set; }
        public int period { get; set; }
        public int unitConvertion { get; set; }
        public string periodName { get; set; }
        public int price { get; set; }
        public int referalBonus { get; set; }
        public bool isActive { get; set; }
    }
}
