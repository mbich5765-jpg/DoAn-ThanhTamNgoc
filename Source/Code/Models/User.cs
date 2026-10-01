using System.ComponentModel.DataAnnotations;
//Người dùng (chứa username, password, role...).
namespace ThanhTamNgoc.Api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int TrangThai { get; set; } = 1;
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public string Role { get; set; } = "Customer"; 
        public bool Status { get; set; } = true;
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        
        public string Address { get; set; }
    }
}