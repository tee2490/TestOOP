using P03_Encapsulate;

var account = new BankAccount();

//public, internal
account.Id = 1;
account.Name = "Test";
account.Rate = 10;

account.SetPassword("1234");


