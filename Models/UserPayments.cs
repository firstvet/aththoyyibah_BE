using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Ath_Thoyyibah_BE.Models
{
    public class UserPayments
    {
        [Key]
        public int userPaymentId { get; set; }
        public int userId { get; set; }
        public int amount { get; set; }
        public int taxAmount { get; set; }
        public int totalAmount { get; set; }
        public DateTime paymentDate { get; set; }
        public string paymentStatus { get; set; }
        public string orderId { get; set; }
        public bool isValid { get; set; }
    }
}
