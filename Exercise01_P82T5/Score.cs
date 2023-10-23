namespace Exercise01_P82T5;

public class Score
{
    public double Test1 { get; set; }
    public double Test2 { get; set; }
    public double Test3 { get; set; }
    public double Test4 { get; set; }

    public double Sum() => Test1 + Test2 + Test3 + Test4;

    public double Average()
    {
        double count = this.GetType().GetProperties().Count();
        return Sum() / count;
    }
}

