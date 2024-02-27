using LogInn;

class Program
{
    static void Main(string[] args)
    {
        Logger.Instance.Log("Application started.");

        // Simulating some operations
        for (int i = 0; i < 5; i++)
        {
            Logger.Instance.Log($"Processing item {i}");
        }
        Logger.Instance.Log("Application finished.");
    }
}
