using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Giỏ hàng (để biết giỏ hàng này của user nào).
namespace ThanhTamNgoc.Api.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public ICollection<CartItem>? CartItems { get; set; }
    }
}