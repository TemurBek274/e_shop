using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Category
    {
        [Key]   
        public int Id { get; set; }
        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Category ParentCategory { get; set; }
        [Required, MaxLength(255)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Icon { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int CretatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public ICollection<ProductCategorie> ProductCategories { get; set; }

    }
}
