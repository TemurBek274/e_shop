using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }
        public decimal RegularPrtice { get; set; }  
        public decimal DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public string ShortDescription { get; set; }
        public int ProducrDescription { get; set; }
        public int ProductWelgth { get; set; }
        public string ProductNote { get; set; }
        public bool Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CretatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public ICollection<ProductCategorie> ProductCategories { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<ProductAttribute> ProductAttributes { get; set; }
        
    }
}