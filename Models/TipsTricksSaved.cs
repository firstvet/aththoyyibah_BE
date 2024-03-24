using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class TipsTricksSaved
    {
        [Key]
        public int tipsTricksSavedId { get; set; }
        public int userId { get; set; }
        public int tipsTricksId { get; set; }
        public int createdBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
