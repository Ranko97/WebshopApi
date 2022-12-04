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
                new Enduser{Id = new Guid("90e93b46-8516-4149-963f-6571ca6fdd2f") ,FirstName = "Marko", LastName = "Markovic", UserName = "marko", Email = "marko@mail.com", IsActive = true},
                new Enduser{Id = new Guid("f76f75e0-47b7-4813-9856-20c2d1bebaa7") ,FirstName = "Petar", LastName = "Petrovic", UserName = "petar", Email = "petar@mail.com", IsActive = true},
            };

            if (!context.Endusers.Any())
            {
                endusers.ForEach(s => context.Endusers.Add(s));
                context.SaveChanges();
            }
            var carsCategory = new Category { Id = new Guid("dce8d948-8587-4040-8537-fff46b8e57a1"), Name = "Cars", Description = "Cars" };
            var computersCategory = new Category { Id = new Guid("fea3f3a3-e7c0-41e8-b965-090e38f9acef"), Name = "Computers" };

            var categories = new List<Category>
            {
                carsCategory, computersCategory
            };

            if (!context.Categories.Any())
            {
                categories.ForEach(s => context.Categories.Add(s));
                context.SaveChanges();
            }

            var products = new List<Product>
            {
                new Product{Id = new Guid("043cf56e-eba0-410a-9515-5e4d2977f3bb"), Category = carsCategory, Name = "Golf 5", Description = "2008 godiste, dobro ocuvan.", },
                new Product{Id = new Guid("0d7765ae-dad6-46b6-a28c-a4f81f998c68"), Category = carsCategory, Name="Opel Astra"},
                new Product{Id = new Guid("22625176-c241-43c1-bf5a-abfcbce89358"), Category = carsCategory, Name = "Nissan Kaskai", Description = "2018 godiste, top stanje", },
                new Product{Id = new Guid("3442ae7e-a053-4516-a3f9-3310142a6e4c"), Category = carsCategory, Name = "Golf 2", Description = "Ganz nov", },
                new Product{Id = new Guid("05d0c3d3-e048-4db0-a0b2-8b9a5ad92dae"), Category = computersCategory, Name = "Desktop Intel", Description = "Intelov procesor i5 12400f", },
                new Product{Id = new Guid("5ee688a2-f3f0-4614-9e7f-5f0e1ce51b86"), Category = computersCategory, Name = "Desktop AMD", Description = "AMD procesor Ryzen 5 5600x", },
                new Product{Id = new Guid("42aefd0c-8d53-494e-a978-6c08f398087f"), Category = computersCategory, Name = "Laptop Thinkpad", Description = "Thinkpad E14 gen 2", },
            };

            if (!context.Products.Any())
            {
                products.ForEach(s => context.Products.Add(s));
                context.SaveChanges();
            }
        }
    }
}