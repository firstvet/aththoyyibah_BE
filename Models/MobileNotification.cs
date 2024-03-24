using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MobileNotification
    {
        [Key]
        public int MobileNotificationId { get; set; }
        public string deviceId { get; set; }
        public int userId { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
