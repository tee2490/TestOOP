using P02_Constructor;

//var products = new Product();
var products = new Product("Banana");
products.GenerateProduct(10);

//static สามารถเข้าหาได้โดยตรงผ่านคลาส
Product.Products.Add( new Product {Id=11,Name="Test",Price=100,Amount=100 } );
Console.WriteLine(Product.Products.Count);


