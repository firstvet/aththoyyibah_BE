using System.ComponentModel.DataAnnotations;

namespace Ath_Thoyyibah_BE.Models
{
    public class MenuSchedule
    {
        [Key]
        public int MenuScheduleId { get; set; }
        public DateTime AssignedDate { get; set; }
        public int MenuId { get; set; }
        public int MemberId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime lmdt { get; set; }
        public int lmby { get; set; }
    }
}
