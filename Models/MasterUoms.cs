using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MasterUoms
    {
        [Key]
        public int UomId { get; set; }
        public string UomName { get; set; }
        public string LMBY { get; set; }
        public DateTime LMDT { get; set; }
        public int IsActive { get; set; }
    }
}
