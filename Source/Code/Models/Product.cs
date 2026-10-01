using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Sản phẩm (Nhẫn, vòng tay... có chứa giá tiền, hình ảnh).
namespace ThanhTamNgoc.Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }

        [StringLength(100)]
        public string GemType { get; set; } 
        
        [StringLength(50)]
        public string Color { get; set; } 
        
        public string CertificateUrl { get; set; }

        public bool IsFeatured { get; set; } 

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}