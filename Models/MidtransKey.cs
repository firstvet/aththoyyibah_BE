using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MidtransKey
    {
        [Key]
        public int MidtransKeyId { get; set; }
        public string Key { get; set; }
    }
}
