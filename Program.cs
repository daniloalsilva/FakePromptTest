using System;
using System.Diagnostics;

namespace FakePromptTest
{
    public static class FakePromptTest
    {

        public static void Main(string[] args)
        {
            // print used params count
            Console.WriteLine($"{args.Length} params used.");

            // if no params used, print help
            if (args.Length <= 0)
            {
                Console.WriteLine(
@"FakePromptTest usage:
    FakePromptTest.exe {int} Param2 Param3

The first param will be considered as second to finish execution (to sleep)
Other used params don't really matter, but will be printed in console

if the first param is not a integer, the program will not sleep

Execution/Result example:

    .\FakePromptTest.exe 10 param2 600

    3 params used.
    params: 10, param2, 600
    Starting Threading.Sleep
    . . . . . . . . . .
    Threading.Sleep Finished. Waiting Time: 10,0075s
"
                );
            }

            else
            {
                // create a timer
                var watcher = Stopwatch.StartNew();


                // print used params
                Console.WriteLine($"params: {string.Join(", ", args)}");

                // hard-coded sleep time, used when no int param was informed
                int.TryParse(args[0], out var sleepTime);

                Console.WriteLine("Starting Threading.Sleep");

                for (int i = 0; i < sleepTime; i++)
                {
                    Console.Write(". ");
                    System.Threading.Thread.Sleep(1000);
                }

                // stop the timer
                watcher.Stop();

                // print executiontime
                Console.WriteLine();
                Console.WriteLine($"Threading.Sleep Finished. Waiting Time: {watcher.Elapsed.TotalSeconds:0.0000}s");
            }
        }
    }
}