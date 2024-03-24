using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class APIKeyCollection
    {
        [Key]
        public int APIKeyId { get; set; }
        public string APIName { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
    }
}
