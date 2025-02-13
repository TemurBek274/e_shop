using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Varlant
    {
        public int Id { get; set; }
        public int VarlantId { get; set; }
        public Decimal Price { get; set; }
        public Decimal Quantity { get; set; }
    }
}
