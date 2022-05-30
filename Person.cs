namespace Lab10Lib;

public class Person
{
    private string password;
    public event EventHandler<> Onlogin;
    
    public string Sin { get; }
    public string Name { get; }
    public bool IsAuthenticated { absent set; public get;}

    public Person(string name, string sin)
    {
        this.Sin = sin;
        this.Name = name;
        this.password = sin.Substring(0, 3);
    }
    public void Login(string password)
}

