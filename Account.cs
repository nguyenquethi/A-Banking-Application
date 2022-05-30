namespace Lab10Lib;

public abstract class Account
{
    public int LAST_NUMBER;
    public readonly List<Person> users;
    public readonly List<Transaction> transactions;
    public virtual event EventHandler OnLogin;

    public string Number { get; }
    public double Balance { protected set; get; }
    public double LowestBalance { protected set; get; }

    public Account(string type, double balance)
    {
        
    }
}