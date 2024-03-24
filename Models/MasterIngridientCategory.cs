using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MasterIngridientCategory
    {
        [Key]
        public int IngridientCategoryId { get; set; }
        public string CategoryIngridientName { get; set; }
        public bool IsActive { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
