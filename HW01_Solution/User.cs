namespace HW01_Solution
{
    public class User
    {
       public Employee Employee { get; set; } = new Employee();

        //Method
        public void Display(int person)
        {
            var IncomeData = Employee.GenerateData(person);
 
            foreach (var item in IncomeData)
            {
                var income = item.Salary + item.Sale * item.Rate;
                var tax = income * 0.05;
                var net = income - tax;

                Console.WriteLine($"{item.Id,5} {item.Name,10} {Show(item.Salary),8}  {Show(item.Sale),10} " +
                    $"{Show(item.Rate),5} {Show(income),15} {Show(tax),15} {Show(net),15}" );
            }
        }

        string Show(double number)
        { 
            return number.ToString("#,###.##");
        }

    }
}
