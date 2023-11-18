namespace P06_Interface
{
    public class ProductService
    {
        public ProductManagement ProductManagement { get; set; }

        public ProductService() 
        {
            ProductManagement = new ProductManagement();
        }

        public void GenerateProduct(int number=1)
        {
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                ProductManagement.AddProduct(new Product
                {
                    Id = i,
                    Name="Coffee-"+i,
                    Price=random.Next(10,200),
                    Category = random.Next(1,6)
                });
            }

        }

        public void DisplayProduct() 
        {
            foreach (var item in ProductManagement.GetProducts())
            {
                Console.WriteLine($"{item.Id,5} {item.Name,-10} {item.Price,5} {item.Category,5}");
            }
        }

        public List<Product> OrderByPrice() 
        {
            var sort = ProductManagement.Products.OrderBy(x => x.Price).ToList();
            return sort;
        }

        public List<TempGroup> GroupByPrice()
        {
            var temp = new List<TempGroup>();
            int tempGr;

            foreach (var item in OrderByPrice())
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ => 3,
                };

                temp.Add(new TempGroup { group = tempGr,category=item.Category });

            }
            return temp;
        }

        public void DisplayGroupByPrice()
        {
            var numOfGroup = GroupByPrice().GroupBy(p=>p.group);

            foreach (var item in numOfGroup)
            {
                Console.Write($"{NameOfPrice(item.Key),8}");
                for (int i = 1; i <= 5; i++)
                    Console.Write($"{item.Count(p=>p.category.Equals(i)),5}");
                Console.WriteLine();
            }
        }

        private string NameOfPrice(int price)
        {
            return price switch
            {
                1 => "10-100",
                2 => "101-200",
                _ => " ",
            };
        }

        public void SearchProduct()
        {
            Console.Write("Enter Id ");
            var id = int.Parse(Console.ReadLine());

            var result = ProductManagement.GetProductById(id);
            if (result == null) Console.WriteLine("Not found");
            else Console.WriteLine($"{result.Id,5} {result.Name,5} {result.Price,5}" +
                $" {result.Category,5}");
        }

        public void SearchByAny()
        {
            Console.Write("Enter number ");
            var number = int.Parse(Console.ReadLine());

            Console.Write("Enter keyword ");
            var keyword = Console.ReadLine();

            var result = ProductManagement.GetProductByAny(number,keyword);
            if (result.Count == 0) Console.WriteLine("Not found");
            else
            {
                result.ForEach(x => Console.WriteLine($"{x.Id,5} {x.Name,5}" +
                    $" {x.Price,5} {x.Category,5}"));
            }
        }
    }

    public class TempGroup
    {
       public int group { get; set; }
       public int category { get; set; }
    }


}
