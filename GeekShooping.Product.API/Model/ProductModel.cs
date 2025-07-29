using GeekShooping.Product.API.Model.Base;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShooping.Product.API.Model
{
    [Table("product")]
    public class ProductModel : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        [Column("price")]
        [Required]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("category_name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("imga_url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
