using e_shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudOperationService
{
    public class CreateProduct
    {
        public readonly ShopContext _context;

        public CreateProduct(ShopContext shopContext)
        {
            _context = shopContext;
        }

        public void productCreated(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public ICollection<Product> products()
        {
            HashSet<Product> products = _context.Products.ToHashSet();
            return products;
        }
    }
}
