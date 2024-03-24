using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class TipsTricks
    {
        [Key]
        public int TipsTricksId { get; set; }
        public string NamaTipsTricks { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
        public bool isPublished { get; set; }
        public int createdBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
