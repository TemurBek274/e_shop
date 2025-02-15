using DataAccess;
using e_shop.Domain.Entities;

using var context = new ShopContext();
var Item = new Category()
{
    Id = 1,
    ParentId = 1,
    CategoryName = "SmartPhone",
    CategoryDescription = "u78i7u6hyty7u8uyhu",
    Icon = " ",
    ImagePath = " "
};


//// crud => create , update , delete , reade
///




var ItemProuct = new Product()
{
    Id = 1,
    ProductName = "Novutbok",
    DiscountPrice = 5,
    RegularPrtice = 2,
    Quantity = 1,
    ShortDescription = "dsafgh",
};

context.Products.Add(ItemProuct);
context.SaveChanges();

//context.Categories.Add(Item);
//context.SaveChanges();
