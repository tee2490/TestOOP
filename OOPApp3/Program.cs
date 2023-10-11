//Global ใช้ทุกที่
string  Id="";
string Name="";
double Price = 0;
double Amount = 0;
double rate1;

Random random = new Random();

//เรียกใช้
Input();
Display();

void Display()
{
    Console.WriteLine($"Id = {Id} Name = {Name} Price = {Price}" +
        $"Amount = {Amount} Sum= {Price*Amount} Process = {Process(rate1)}");
}

void Input()
{
    Console.Write("Input id ");
    Id = Console.ReadLine();

    Console.Write("Input name ");
    Name = Console.ReadLine();

    Console.Write("Input Discount Rate 0 - 1 ");
    rate1 = double.Parse(Console.ReadLine());

    Price = random.Next(10, 100);
    Amount = random.Next(1, 10);
    
}

double Process(double rate=0)
{
    //local เฉพาะที่
    var sum = Price * Amount;
    var result = sum - sum * rate;
    return result;
}