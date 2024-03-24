using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class Menus
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }

        [AllowNull]
        public string? Note { get; set; }

        [AllowNull]
        public string? PhotoURL { get; set; }
        [AllowNull]
        public string? VideoURL { get; set; }
        public bool IsPublished { get; set; }
        public int CreatedBy { get; set; }
        public int Rate { get; set; }
        public string LMBY { get; set; }
        public DateTime LMDT { get; set; }
    }
}
