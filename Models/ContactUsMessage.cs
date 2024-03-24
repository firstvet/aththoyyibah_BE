using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class ContactUsMessage
    {
        [Key]
        public int contactUsMessageId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public DateTime dateTime { get; set; }
    }
}
