namespace P02_Constructor
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
 

        //Constructor ชื่อเดียวกับคลาส
        public Product()
        {
            Products = new List<Product>();
        }

        public Product(int number)
        {
            Console.WriteLine($"{number}");
        }

        public Product(string Name)
        {
            Products = new List<Product>();

            //this คือ ระบุว่าเป็น properties ภายในคลาส
            this.Name = Name;
        }


        public List<Product> Products { get; set; }

        public void GenerateProduct(int number = 1)
        {
            Random rand = new Random();

            for (int i = 1; i <= number; i++)
            {
                Products.Add(new Product
                {
                    Id = i,
                    Name = Name+i,
                    Price = rand.NextDouble() * 990 + 10,
                    Amount = rand.Next(10, 50)
                });
            }

        }

        public void Display()
        {
            Products.ForEach(p=>Console.WriteLine($"{p.Id} {p.Name} {p.Price.ToString("#,###.##")} {p.Amount}"));
        }



    }
}
