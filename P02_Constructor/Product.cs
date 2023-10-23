namespace P02_Constructor
{
    public class Product
    {
        //Constructor ชื่อเดียวกับคลาส
        public Product()
        {
            Console.WriteLine("Test Contructor");   
        }

        public Product(int number)
        {
            Console.WriteLine($"{number}");
        }

        public Product(int number,string name)
        {
            Console.WriteLine($"{number} {name}");
        }

        public void Productxxx()
        {

        }



    }
}
