using System;
using System.Threading;

namespace mutexLab
{
    class Lab4
    {
        static void Main(string[] args)
        {
            bool createdNew;

            Mutex m = new Mutex(true, "myApp", out createdNew);

            if (!createdNew)
            {
                // myApp is already running...
                Console.WriteLine("myApp is already running!", "Multiple Instances");
                return;
            }
        }
    }
}
