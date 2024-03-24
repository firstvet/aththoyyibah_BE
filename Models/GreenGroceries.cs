using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class GreenGroceries
    {
        [Key]
        public int GreenGroceryId { get; set; }
        public string GroceryName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
