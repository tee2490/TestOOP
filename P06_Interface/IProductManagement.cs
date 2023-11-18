namespace P06_Interface
{
    //Add Edit Delete Search
    public interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductByAny(int number,string keyword);
        void DeleteById(Product product);

        void UpdateProduct(Product NewProduct,Product OldProduct);
        Product InputProduct(Product product);

    }
}
