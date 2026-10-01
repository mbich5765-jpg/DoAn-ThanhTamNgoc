using System.ComponentModel.DataAnnotations;
//Danh mục (chứa thông tin Phỉ Thúy, Ruby, Ngọc Lục Bảo...).
namespace ThanhTamNgoc.Api.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}