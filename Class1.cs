using System;


public class BankAccount
{
    private double balance; // Приватное поле, не доступно извне

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    // Метод для добавления средств на счет
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Метод для получения текущего баланса
    public double GetBalance()
    {
        return balance;
    }
}

//В этом примере переменная balance инкапсулирована в классе BankAccount. Она приватная, доступ к ней возможен только через публичные методы Deposit и GetBalance.