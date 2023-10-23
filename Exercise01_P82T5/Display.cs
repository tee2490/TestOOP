namespace Exercise01_P82T5;

    public class Display
    {
    public Display()
    {
        new GenerateScore(15);
    }

    public void ShowScore()
    {
        var avg1 = GenerateScore.ScoreList.Average(p => p.Test1);
        var avg2 = GenerateScore.ScoreList.Average(p => p.Test2);
        var avg3 = GenerateScore.ScoreList.Average(p => p.Test3);
        var avg4 = GenerateScore.ScoreList.Average(p => p.Test4);

        foreach (var item in GenerateScore.ScoreList)
        {
           Console.WriteLine($"{item.Test1,5} {item.Test2,5} {item.Test3,5} {item.Test4,5}" +
               $" {item.Sum(),8} {item.Average(),8}");
        }
        Console.WriteLine();
        Console.WriteLine($"{avg1,5:n2} {avg2,5:n2} {avg3,5:n2} {avg4,5:n2}");

    }
    
}

