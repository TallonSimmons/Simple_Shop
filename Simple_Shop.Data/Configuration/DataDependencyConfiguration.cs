using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simple_Shop.Data.Contexts;
using Simple_Shop.Data.Repositories;
using Simple_Shop.Domain.DataModels;
using Simple_Shop.Domain.Entities;
using Simple_Shop.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Shop.Data.Configuration
{
    public class DataDependencyConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddDbContext<AppDbContext>(options => options
            .UseInMemoryDatabase(databaseName: "Simple_Shop")
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors());
            Seed(services);
        }

        public static void Seed(IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                var products = new List<ProductDTO>()
                {
                    new ProductDTO()
                    {
                        Id = 1,
                        Title = "Imported Bottle of Perfume",
                        Price = 27.99M,
                        Imported = true,
                        ProductTypeId = (int)ProductType.Taxable
                    },
                    new ProductDTO()
                    {
                        Id = 2,
                        Title = "Book",
                        Price = 12.49M,
                        Imported = false,
                        ProductTypeId = (int)ProductType.NonTaxable
                    },
                    new ProductDTO()
                    {
                        Id = 3,
                        Title = "Music CD",
                        Price = 14.99M,
                        Imported = false,
                        ProductTypeId = (int)ProductType.Taxable
                    },
                    new ProductDTO()
                    {
                        Id = 4,
                        Title = "Chocolate Bar",
                        Price = 0.85M,
                        Imported = false,
                        ProductTypeId = (int)ProductType.NonTaxable
                    },
                    new ProductDTO()
                    {
                        Id = 5,
                        Title = "Imported Box of Chocolates",
                        Price = 10.00M,
                        Imported = true,
                        ProductTypeId = (int)ProductType.NonTaxable
                    },
                    new ProductDTO()
                    {
                        Id = 6,
                        Title = "Imported Box of Chocolates",
                        Price = 11.25M,
                        Imported = true,
                        ProductTypeId = (int)ProductType.NonTaxable
                    },
                    new ProductDTO()
                    {
                        Id = 7,
                        Title = "Imported Bottle of Perfume",
                        Price = 47.50M,
                        Imported = true,
                        ProductTypeId = (int)ProductType.Taxable
                    },
                    new ProductDTO()
                    {
                        Id = 8,
                        Title = "Bottle of Perfume",
                        Price = 18.99M,
                        Imported = false,
                        ProductTypeId = (int)ProductType.Taxable
                    },
                    new ProductDTO()
                    {
                        Id = 9,
                        Title = "Packet of Headache Pills",
                        Price = 9.75M,
                        Imported = false,
                        ProductTypeId = (int)ProductType.NonTaxable
                    }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
