
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
        List<Employee> GenerateData(int number=1)
        {
            var data = new List<Employee>();
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                data.Add( new Employee {
                    Id = i,
                    Name = "Employee"+i,
                    Salary = random.Next(10000,999999),
                    Sale = random.Next(500_000,1000_000),
                    Rate = random.NextDouble() * 10,
                } );
            }
            return data;
        }

        //Method
        public void Display(int person)
        {
            var IncomeData = GenerateData(person);

            foreach (var item in IncomeData)
            {
                var income = item.Salary + item.Sale * item.Rate;
                var tax = income * 0.05;
                var net = income - tax ;

                Console.WriteLine($"{item.Id} {item.Name} {item.Salary} {item.Sale} " +
                    $"{item.Rate} {income} {tax} {net}");
            }
        }

    }
}
