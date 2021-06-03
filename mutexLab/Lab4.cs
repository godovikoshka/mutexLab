using System;
using System.Threading;

class Program
{
    static Mutex _mutex;

    static bool IsSingleInstance()
    {
        try
        {
            Mutex.OpenExisting("mut");
        }
        catch
        {
            _mutex = new Mutex(true, "mut");
            return true;
        }

        return false;
    }

    static void Main()
    {
        if (!IsSingleInstance())
        {
            Console.WriteLine("More than one instance");
        }
        else
        {
            Console.WriteLine("One instance");
        }
        Console.Write("\nPress 'Enter' to end the process...");
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
        }

    }
}
