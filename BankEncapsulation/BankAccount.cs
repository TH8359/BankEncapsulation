namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;

    public void Deposit(double newBalance)
    {
        _balance += newBalance;
    }

    public double GetBalance()
    {
        return _balance;
    }
}