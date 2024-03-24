using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ath_Thoyyibah_BE.Models
{
    public class ApplicationUser
    {
        [Key]
        public int userId { get; set; }
        public string email { get; set; }
        [AllowNull]
        public string? firstName { get; set; }
        [AllowNull]
        public string? lastName { get; set; }
        [AllowNull]
        public string? sex { get; set; }
        [AllowNull]
        public string? education { get; set; }
        [AllowNull]
        public string? remarks { get; set; } = null;
        [AllowNull]
        public DateTime? dateofBirth { get; set; }
        [AllowNull]
        public string? referalCode { get; set; }
        public string password { get; set; }
        public string passwordHash { get; set; }
        [AllowNull]
        public string? photoURL { get; set; }
        [AllowNull]
        public int roleId { get; set; }
        public bool isActive { get; set; }
        public int lmby { get; set; }
        [AllowNull]
        public int subscriptionId { get; set; }
        [AllowNull]
        public DateTime lmdt { get; set; }
        [AllowNull]
        public DateTime RegisterDate { get; set; }

    }
}
