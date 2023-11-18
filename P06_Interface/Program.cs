using P06_Interface;

var ps = new ProductService();

ps.GenerateProduct(20);
ps.DisplayProduct();

//Console.WriteLine();
//ps.DisplayGroupByPrice();

//ps.SearchProduct();

ps.SearchByAny();