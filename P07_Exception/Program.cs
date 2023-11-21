try
{
    var test = int.Parse(Console.ReadLine());
}
catch (Exception TestError)
{ 
    Console.WriteLine(TestError.Message);
}
