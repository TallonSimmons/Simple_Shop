using Simple_Shop.Domain.Entities;

namespace Simple_Shop.Web.Helpers
{
    public class ProductList
    {
        public Product ImportedPerfume1 = new Product()
        {
            Id = 1,
            Title = "Imported Bottle of Perfume",
            Price = 27.99M,
            Imported = true,
            ProductTypeId = (int)ProductType.Taxable


        };

        public Product Book = new Product()
        {
            Id = 2,
            Title = "Book",
            Price = 12.49M,
            Imported = false,
            ProductTypeId = (int)ProductType.NonTaxable
        };
        public Product Cd = new Product()
        {
            Id = 3,
            Title = "Music CD",
            Price = 14.99M,
            Imported = false,
            ProductTypeId = (int)ProductType.Taxable
        };
        public Product Chocolate = new Product()
        {
            Id = 4,
            Title = "Chocolate Bar",
            Price = 0.85M,
            Imported = false,
            ProductTypeId = (int)ProductType.NonTaxable
        };
        public Product ImportedChocolate1 = new Product()
        {
            Id = 5,
            Title = "Imported Box of Chocolates",
            Price = 10.00M,
            Imported = true,
            ProductTypeId = (int)ProductType.NonTaxable
        };
        public Product ImportedChocolate2 = new Product()
        {
            Id = 6,
            Title = "Imported Box of Chocolates",
            Price = 11.25M,
            Imported = true,
            ProductTypeId = (int)ProductType.NonTaxable
        };
        public Product ImportedPerfume2 = new Product()
        {
            Id = 7,
            Title = "Imported Bottle of Perfume",
            Price = 47.50M,
            Imported = true,
            ProductTypeId = (int)ProductType.Taxable
        };
        public Product Perfume = new Product()
        {
            Id = 8,
            Title = "Bottle of Perfume",
            Price = 18.99M,
            Imported = false,
            ProductTypeId = (int)ProductType.Taxable
        };
        public Product Pills = new Product()
        {
            Id = 9,
            Title = "Packet of Headache Pills",
            Price = 9.75M,
            Imported = false,
            ProductTypeId = (int)ProductType.NonTaxable
        };
    }
}
