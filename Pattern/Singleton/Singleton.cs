class Singleton
{
    private static Singleton? _singleton;
    private static readonly object _lock = new object();
    public static Singleton GetSingleton()
    {
        if (_singleton == null)
        {
            lock(_lock)
            {
                if(_singleton == null)
                    _singleton = new Singleton();
            }
        }
        return _singleton;
    }
    
}