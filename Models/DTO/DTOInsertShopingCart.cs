namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOInsertShopingCart
    {
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public int ReservedBy { get; set; }
        public DateTime ReservedDate { get; set; }
        public string Status { get; set; }
    }
}
