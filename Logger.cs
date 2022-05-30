namespace Lab10Lib;

public class Logger
{
    private List<string> loginEvents;
    private List<string> transactionEvents;

    public static void LoginHandler(object sender, EventArgs args)
    {
        LoginEventArgs x = args as LoginEventArgs;
        String str = $"{x.PersonName} {x.Success}"
    }
}