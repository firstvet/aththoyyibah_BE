using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOUpdateQuantityShopingCart
    {
        public int ShopingChartId { get; set; }
        public int Quantity { get; set; }
        [AllowNull]
        public int ReservedBy { get; set; }
        public DateTime ReservedDate { get; set; }
        public string Status { get; set; }
    }
}
