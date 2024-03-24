
using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class SubscriptionPeriods
    {
        [Key]
        public int subscriptionPeriodsId { get; set; }
        public int period { get; set; }
        public int unitConversion { get; set; }
        public string periodName { get; set; }
        public int price { get; set; }
        public int referalBonus { get; set; }
        public bool isActive { get; set; }

    }
}
