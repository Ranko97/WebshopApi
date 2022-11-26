using Models;
using Data.Models;

namespace Data
{
    public class DbSeedInitializer
    {
        public void Initialize(AppDbContext context)
        {
            var endusers = new List<Enduser>
            {
                new Enduser{Id = new Guid("90e93b46-8516-4149-963f-6571ca6fdd2f") ,FirstName = "Marko", LastName = "Markovic", IsActive = true},
                new Enduser{Id = new Guid("f76f75e0-47b7-4813-9856-20c2d1bebaa7") ,FirstName = "Petar", LastName = "Petrovic", IsActive = true},
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