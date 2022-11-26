using Models;
using Data.Models;

namespace Data
{
    public class DbSeedInitializer
    {
        public void Seed(AppDbContext context)
        {
            var endusers = new List<Enduser>
            {
                new Enduser{FirstName = "Marko", LastName = "Markovic"},
                new Enduser{FirstName = "Petar", LastName = "Petrovic"},
            };

            endusers.ForEach(s => context.Endusers.Add(s));
            context.SaveChanges();

            var carsCategory = new Category { Id = Guid.NewGuid(), Name = "Cars", Description = "Cars" };
            var computersCategory = new Category { Id = Guid.NewGuid(), Name = "Computers" };

            var categories = new List<Category>
            {
                carsCategory, computersCategory
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Category = carsCategory, Name = "Golf 5", Description = "2008 godiste, dobro ocuvan.", },
                new Product{Category = carsCategory, Name="Opel Astra"},
                new Product{Category = carsCategory, Name = "Nissan Kaskai", Description = "2018 godiste, top stanje", },
                new Product{Category = carsCategory, Name = "Golf 2", Description = "Ganz nov", },
                new Product{Category = computersCategory, Name = "Desktop Intel", Description = "Intelov procesor i5 12400f", },
                new Product{Category = computersCategory, Name = "Desktop AMD", Description = "AMD procesor Ryzen 5 5600x", },
                new Product{Category = computersCategory, Name = "Laptop Thinkpad", Description = "Thinkpad E14 gen 2", },
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}