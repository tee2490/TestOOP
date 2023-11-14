
using P05_Interface.ITest;

namespace P05_Interface.CTest
{
    internal class TestData : InterfaceTest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Your Id is " + Id);
            Console.WriteLine("Your Name is " + Name);
        }

        public void Input()
        {
            Id = 2;
            Name = "foo";
        }
    }
}
