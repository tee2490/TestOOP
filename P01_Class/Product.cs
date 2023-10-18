
namespace P01_Class
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public void Display() => Console.WriteLine($"{Id} {Name} {Price.ToString("#,###.##")} {Amount}");
        
        public List<Product> GenerateProduct(int number=1)
        {
            var products = new List<Product>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = "Coffee" + i,
                    Price = rand.NextDouble() * 990 + 10,
                    Amount = rand.Next(10, 50)
                });
            }

            return products;
        }

    }
}
