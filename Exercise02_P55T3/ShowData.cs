namespace Exercise02_P55T3
{
    internal class ShowData
    {
        public GenerateData GenerateData { get; set; }
        public ShowData()
        {
            GenerateData = new GenerateData(20);
        }

        public void DisplayBySection()
        {

            foreach (var emp in GenerateData.SortBySection())
            {
                Console.WriteLine($"{emp.Section,5} {NameOfSection(emp.Section),-15} {emp.Id,5} {emp.Age,5}");
            }
        }

        public void DisplayBySectionGroup()
        {
            foreach (var group in GenerateData.GroupOfSection())
            {
                Console.WriteLine(NameOfSection(group.Key));
                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Section,5} {emp.Id,5} {emp.Age,5}");
                }

            }
        }

        public string NameOfSection(int section)
        {
            string name=string.Empty; 

            switch (section)
            {
                case 1: name = "Account"; break;
                case 2: name = "Person"; break;
                case 3: name = "IT"; break;
                case 4: name = "Marketing"; break;
                case 5: name = "Sale"; break;
            }

            return name;
        }

        public void DisplayByGroupAge()
        {
            foreach (var group in GenerateData.GroupOfAge())
            {
                Console.Write($"{NameOfAge(group.Key),8}");
               
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{group.Count(p=>p.Section == i),5}");
                }
              
                Console.WriteLine();
            };
        }

        public string NameOfAge(int age)
        {
            string name = string.Empty;

            switch (age)
            {
                case 1: name = "25-30"; break;
                case 2: name = "31-40"; break;
                case 3: name = "41-50"; break;
                case 4: name = "51-60"; break;
            }
            return name;
        }

    }

}
