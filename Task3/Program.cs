var bankAccount = new BankAccount(15,20000,"Yusuf Rahmon");
bankAccount.TopUp(5000);
bankAccount.Withdraw(3000);
System.Console.WriteLine(bankAccount.PrintStatement());
