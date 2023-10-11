//Global ใช้ทุกที่
string  Id="11";
string Name="Coffee";
double Price = 10;
double Amount = 10;
double rate1=0.5;

Random random = new Random();

//เรียกใช้
//Input();
Display();
Update(ref Id,ref Name,Price);
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

//การส่งตัวแปรแบบอ้างอิง
void Update(ref string id,ref string name,double price)
{
    id = id + "555";
    name = name + "555";
    price = price + 555;
}