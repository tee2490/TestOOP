

using P05_Interface.ITest;

namespace P05_Interface.CTest
{
    //How
    public class ClassTest : InterfaceTest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ClassTest()
        {
            Input();
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name}");
        }

        public void Input()
        {
            Id = 1;
            Name = "test";
        }

 
    }
}
