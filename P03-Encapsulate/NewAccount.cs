namespace P03_Encapsulate
{
    internal class NewAccount : BankAccount
    {
        public NewAccount()
        {
            Id = 1;
            Name = "Test";

            // Private Password สืบทอดไม่ได้
            Rate = 100;

            // Protected สืบทอดได้ แต่เรียกใช้ทางอ้อม
            Money = 100;
        }


        //เรียกใช้ Protect แบบทางอ้อม(ภายในคลาส)
        public void WithDraw(int money)
        {
            if(Money > 0 && money <= Money)
            {
                Money -= money;
                Console.WriteLine(Money);
            }
            else
            {
                Console.WriteLine("Cannot withdraw");
            }
        }

    }
}
