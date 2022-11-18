namespace Logger;

public sealed class Logger
{
    //eager loading
    //private static readonly Logger _logger = new Logger();

    //lazy loading
    private static Logger _instance;

    private Logger()
    {
    }
    //public static Logger Instance 
    //{
    //	get
    //	{
    //    if (_instance == null) _instance = new Logger();
    //           return _instance;
    //    }
    //}

    public static Logger GetInstance()
    {
        if (_instance == null) _instance = new Logger();

        return _instance;
    }

    public void Ss()
    {
        Console.WriteLine("Hi");
    }
}
