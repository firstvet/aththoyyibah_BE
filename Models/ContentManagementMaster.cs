using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class ContentManagementMaster
    {
        [Key]
        public int ContentManagementId { get; set; }
        public bool IsLogedIn { get; set; }
        public string PageName { get; set; }
        public string TitleContent { get; set; }
        public string Content { get; set; }
        [AllowNull]
        public string URL { get; set; }
        public int LMBY { get; set; }
        public DateTime? LMDT { get; set; }


    }
}
