namespace Ath_Thoyyibah_BE.Models.DTO
{
    public class DTOInsertContentManagementMaster
    {

        public bool isLogedIn { get; set; }
        public string pageName { get; set; }
        public string titleContent { get; set; }
        public string content { get; set; }

        public string url { get; set; }
        public int lmby { get; set; }
        public DateTime? lmdt { get; set; }
    }
}
