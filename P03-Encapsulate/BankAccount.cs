
namespace P03_Encapsulate
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        protected double Money { get; set; }
        internal double Rate { get; set; }


        //เรียกใช้ Private โดยทางอ้อมผ่านเมธอด
        public void SetPassword(string Password)
        {
            this.Password = Password;

            if (this.Password == "1234") 
            {
                Console.WriteLine(Money);
            }
            else
            {
                Console.Write(Money);
            }
        }
    }
}
