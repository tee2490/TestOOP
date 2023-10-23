namespace Exercise01_P82T5
{
    public class GenerateScore
    {
        static public List<Score> ScoreList;

        public GenerateScore(int number)
        {
            ScoreList = new List<Score>();
            Generate(number);
        }

        void Generate(int number) 
        {
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                ScoreList.Add(new Score 
                { 
                    Test1 = random.Next(0,100) + 1,
                    Test2 = random.Next(0, 100) + 1,
                    Test3 = random.Next(0, 100) + 1,
                    Test4 = random.Next(0, 100) + 1,
                });
            }
            
        }

    }
}
