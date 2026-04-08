using FullAsyncEntityProject.DataAccess;
using FullAsyncEntityProject.DataAccess.Concrete.EntityFramework;
using FullAsyncEntityProject.Entities;
using FullAsyncEntityProject.Services.Concrete;

namespace FullAsyncEntityProject
{
    public class Program
    {
        static async void Start()
        {
            using (var context = new StepDBContext())
            {
                var productDal = new EFProductDal(context);
                var productService = new ProductService(productDal);

                //var newEntity = new Product
                //{
                //    Name = "Asus Zenbook DUO",
                //    Description = "Ela chox monitorlu laptop",
                //    Price = 4200,
                //    Quantity = 20
                //};

                //await productService.AddAsync(newEntity);

                var products = await productService.GetListAsync();
                foreach (var p in products)
                {
                    Console.WriteLine($"ID : {p.Id}");
                    Console.WriteLine($"Name : {p.Name}");
                    Console.WriteLine($"Description : {p.Description}");
                    Console.WriteLine($"Price : {p.Price}$");
                    Console.WriteLine($"Quantity : {p.Quantity}");
                    Console.WriteLine();
                }

            }
        }

        static async Task Menu()
        {

        }

        static void Main(string[] args)
        {
            Start();
            Console.ReadLine();
        }
    }
}
