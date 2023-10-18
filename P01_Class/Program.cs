
using P01_Class;

//Object วัตถุ
Product product = new Product();
Product ton = new Product();
Product Sumo = new Product();

product.Id = 1;
product.Name = "Coffee";
product.Price = 10;
product.Amount = 20;

ton.Id = 2;
ton.Name = "Cream";
ton.Price = 20;
ton.Amount = 20;

product.Display();
ton.Display();

