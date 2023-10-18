
using P01_Class;

//Object วัตถุ
Product product = new Product();
Product ton = new Product();
Product Sumo = new Product();

product.Input(new Product {Id=1,Name="Coffee",Price=100,Amount=10 });
ton.Input(new Product { Id = 2, Name = "Coffee2", Price = 200, Amount = 20 });


product.Display();
ton.Display();

