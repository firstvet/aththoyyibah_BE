namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOInsertBankAccount
    {
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public IFormFile BankLogo { get; set; }
        public bool IsActive { get; set; }
    }
}
