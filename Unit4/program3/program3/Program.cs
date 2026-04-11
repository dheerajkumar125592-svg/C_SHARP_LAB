using System;


abstract class Account
{
    protected int accountNo;
    protected double balance;

  
    public Account(int accNo, double bal)
    {
        accountNo = accNo;
        balance = bal;
    }

    
    public void CheckBalance()
    {
        Console.WriteLine("Account No: " + accountNo);
        Console.WriteLine("Balance: " + balance);
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public abstract void Withdraw(double amount);
}


class Savings : Account
{
    double interestRate;

    public Savings(int accNo, double bal, double rate) : base(accNo, bal)
    {
        interestRate = rate;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance in Savings!");
        }
    }

    public void ShowInterest()
    {
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}


class Current : Account
{
    double overdraftLimit;

    public Current(int accNo, double bal, double limit) : base(accNo, bal)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded!");
        }
    }

    public void ShowOverdraft()
    {
        Console.WriteLine("Overdraft Limit: " + overdraftLimit);
    }
}

class Program
{
    static void Main()
    {
        Savings s = new Savings(101, 5000, 5);
        Console.WriteLine("Savings Account:");
        s.CheckBalance();
        s.Deposit(1000);
        s.Withdraw(2000);
        s.ShowInterest();
        s.CheckBalance();

        Console.WriteLine();

       
        Current c = new Current(102, 3000, 2000);
        Console.WriteLine("Current Account:");
        c.CheckBalance();
        c.Deposit(500);
        c.Withdraw(4000);
        c.ShowOverdraft();
        c.CheckBalance();
    }
}