namespace Lab10Lib;

public class LoginEventArgs
{
    private string _name;
    private bool _success;
    public string PersonName
    {
        get { return PersonName; }
    }
    
    public bool Success {
        get { }
    }

    public LoginEventArgs(string name, bool success)
    {
        PersonName = name;
        Success = success;
    }
}