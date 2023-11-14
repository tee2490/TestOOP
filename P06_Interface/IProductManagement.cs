namespace P06_Interface
{
    public interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();

    }
}
