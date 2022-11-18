namespace Logger;

//Thread-safe
public sealed class Log
{
	private static readonly object lockObj = new object();
    private static Log _instance;

	private Log()
	{
	}

	public static Log Instance 
	{
		get
		{
			if (_instance == null)
			{
				lock (lockObj)
				{
					if(_instance == null)
					{
						_instance = new Log();
					}
				}
			}
			return _instance;
		}
	}
}
