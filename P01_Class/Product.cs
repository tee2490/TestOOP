
namespace P01_Class
{
    public class Product  //แม่แบบ แบบฟอร์มกระดาษ
    {
        //attributes, property คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        //Default Method get set
        //get อ่านค่า
        //set ใส่ค่า

        // => Lamda, Arrow function
        //Method
        public void Display() => Console.WriteLine($"{Id} {Name} {Price} {Amount}");

        public void Input(Product product) 
        { 
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Amount = product.Amount;
        }
        
    }
}
