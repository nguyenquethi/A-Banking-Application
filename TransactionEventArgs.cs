namespace Lab10Lib;

public class TransactionEventArgs
{
    public double Amount { get; }

    public TransactionEventArgs(string personName, double amount, bool success)
    {
        Amount = amount;
    }
}