
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW01_Solution
{
    public class Employee
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Sale { get; set; }
        public double Rate { get; set; }


        //Method
        public List<Employee> GenerateData(int number=1)
        {
            var data = new List<Employee>();
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                data.Add( new Employee {
                    Id = i,
                    Name = "Employee"+i,
                    Salary = random.Next(10000,99999),
                    Sale = random.Next(500_000,1000_000),
                    Rate = random.NextDouble() * 10,
                } );
            }
            return data;
        }

    }
}
