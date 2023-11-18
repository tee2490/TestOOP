namespace P06_Interface
{
    public class ProductManagement : IProductManagement
    {
        public List<Product> Products { get; set; }

        public ProductManagement()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product GetProductById(int productId)
        {
          //  Products.Where(p=>p.Id == productId).FirstOrDefault();
          //  Products.Find(p=>p.Id.Equals(productId));
          return  Products.FirstOrDefault(p => p.Id == productId);
        }

        public List<Product> GetProductByAny(int number=0, string keyword="")
        {
            if (String.IsNullOrEmpty(keyword)) keyword = "XXX";

          var result =  Products.Where(p=>p.Name.ToUpper().Contains(keyword.ToUpper()) ||
            p.Id.Equals(number) ||
            p.Price > number ||
            p.Category.Equals(number)).ToList();

            return result;
        }
    }
}
