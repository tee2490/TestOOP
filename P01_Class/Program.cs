
using P01_Class;

//list ไม่จำกัดจำนวน
List<Product> products = new List<Product>();
Random rand = new Random();

for (int i = 1; i < 10; i++)
{
    products.Add(new Product 
    { 
        Id = i,
        Name = "Coffee"+i,
        Price = rand.NextDouble() * 990 + 10,
        Amount = rand.Next(10,50)
    });
}

products.ForEach(p => p.Display());
