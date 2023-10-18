
namespace P01_Class
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public void Display() => Console.WriteLine($"{Id} {Name} {Price.ToString("#,###.##")} {Amount}");
                
    }
}
