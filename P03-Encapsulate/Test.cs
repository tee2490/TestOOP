

using P03_Encapsulate;

namespace P03_Test
{
    //การเรียกใช้ internal ในโปรเจคเดียวกันสามารถทำได้
    public class Test
    {
        //Contructor
        public Test()
        {
            var temp = new BankAccount();

            //internal
            temp.Rate = 100;
        }
    }
}
