namespace Lab10Lib;

public interface ITransaction
{
    void Withdraw(double amount, Person person);
    void Deposit(double amount, Person person);
}