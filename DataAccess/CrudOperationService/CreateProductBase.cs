using e_shop.Domain.Entities;

namespace DataAccess.CrudOperationService
{
    public abstract class CreateProductBase
    {
        public abstract void CreateProduct(Product product);
    }
}