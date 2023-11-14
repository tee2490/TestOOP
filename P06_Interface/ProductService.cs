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
                    Price=random.Next(10,200)
                });
            }

        }

        public void DisplayProduct() 
        {
            foreach (var item in ProductManagement.GetProducts())
            {
                Console.WriteLine($"{item.Id,5} {item.Name,-10} {item.Price,5}");
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

                temp.Add(new TempGroup { group = tempGr });

            }
            return temp;
        }

        public void DisplayGroupByPrice()
        {
            var numOfGroup = GroupByPrice().GroupBy(p=>p.group);

            foreach (var item in numOfGroup)
            {
                Console.WriteLine($"{NameOfPrice(item.Key),8} " +
                    $"{GroupByPrice().Count(p=>p.group == item.Key)}");
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

    }

    public class TempGroup
    {
       public int group { get; set; }
    }


}
