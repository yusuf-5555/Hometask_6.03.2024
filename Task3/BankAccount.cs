using System.Reflection;

public class BankAccount
{
    public int accountNumber;
    decimal _balance;
    public string Owner;

    public BankAccount(int accountNum, decimal balance, string owner)
    {
        accountNumber  = accountNum;
        _balance = balance;
        Owner = owner;
    }

    public void TopUp(decimal amount)
    {
        _balance = _balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        _balance = _balance - amount;
    }

    public decimal PrintStatement()
    {
        return _balance;
    }
}