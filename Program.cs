using System;
using System.Threading;

namespace TimerCallbacks
{
    class Program
    {
        // Many applications have the need to call a specific method during regular intervals of time.
        // For situations such as these, you can use the System.Threading.Timer type
        // in conjunction with a related delegate named TimerCallback.
        static void Main()
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            Console.WriteLine("Hit Enter key to terminate...");

            // Create the delegate for the Timer type.
            TimerCallback timeCB = new TimerCallback(PrintTime);

            // Establish timer settings.
            Timer t = new Timer(
                timeCB, // The TimerCallback delegate object.
                null, // Any info to pass into the called method (null for no info).
                0, // Amount of time to wait before starting (in milliseconds).
                1000); // Interval of time between calls (in milliseconds).

            //////////////////////////////////////////////////////////////////////////

            // Create the delegate for the Timer type.
             TimerCallback timeCBGreet = new TimerCallback(SayHi);

            // Establish timer settings.
            // Using a Stand-Alone Discard (New 7.0)
            //Timer _ = new Timer(timeCBGreet, "Hello From C# 9.0", 0, 1000);

            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}", DateTime.Now.ToLongTimeString());
        }

        static void SayHi(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }
    }
}