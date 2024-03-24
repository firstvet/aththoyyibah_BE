using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class ShopingTransactions
    {
        [Key]
        public int ShoppingTranscationsId { get; set; }
        public int MenuId { get; set; }
        public int IngredientsId { get; set; }
        public int Qty { get; set; }
        public string UoM { get; set; }
        public string Status { get; set; }
        public int LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
