namespace Exercise02_P55T3
{
    internal class GenerateData
    {
        public List<Employee> Employees;
        public List<GroupAge> GroupAges;

        public GenerateData(int num=5)
        {
            Employees = new List<Employee>();
            GroupAges = new List<GroupAge>();

            CreateEmployee(num);
        }

        public void CreateEmployee(int number)
        { 
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                Employees.Add(new Employee
                {
                    Id = i,
                    Section = random.Next(1, 6),
                    Age = random.Next(25, 61),
                }); ;
            }
        }

        public List<Employee> SortBySection()=>Employees.OrderBy(p=>p.Section).ToList();

        public List<Employee> SortByAge() => Employees.OrderBy(p => p.Age).ToList();

        public dynamic GroupOfSection()
        {
            Employees = SortBySection();
            return Employees.GroupBy(p=>p.Section).ToList();
        }

        public List<IGrouping<int,GroupAge>> GroupOfAge()
        {
            Employees = SortByAge();

            int groupTemp;
            foreach (var item in Employees)
            {
                //Lamda C# V8
                groupTemp = item.Age switch
                {
                    <=30 => 1,
                    <=40 => 2,
                    <=50 => 3,
                    _ => 4,
                    
                };

                GroupAges.Add(new GroupAge { GroupOfAge = groupTemp,Section=item.Section});
            }
            return GroupAges.GroupBy(p=>p.GroupOfAge).ToList();
        }



    }
}
