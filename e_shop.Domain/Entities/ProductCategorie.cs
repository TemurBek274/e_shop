using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class ProductCategorie
    {

        public int CategoryId { get; set; }
        public int ProducrId { get; set; }

        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
