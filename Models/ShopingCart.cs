using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class ShopingCart
    {
        public int ShopingCartId { get; set; }
        public int MenuId { get; set; }
        public int ReservedBy { get; set; }
        public DateTime ReservedDate { get; set; }
        public int Quantity { get; set; }
        [AllowNull]
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
    }
}
