using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class ProductAttribute
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AttributeId { get; set; }
        public AttributeDb AttributeDb { get; set; }
        
    }
}
