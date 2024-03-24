namespace Ath_Thoyyibah_BE.Models
{
    public class OTPUsers
    {
        public int OTPUsersId { get; set; }
        public int UserId { get; set; }
        public Int64 OTP { get; set; }
        public DateTime ValidStart { get; set; }
        public DateTime ValidEnd { get; set; }
        public bool IsActive { get; set; }
    }
}
