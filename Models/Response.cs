namespace Ath_Thoyyibah_BE.Models
{
    public class Response
    {
        public string code { get; set; }
        public string message { get; set; }
        public DateTime responseTime { get; set; }
        public DateTime requestTime { get; set; }
        public object data { get; set; }
    }
}
