using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _starting;
        private DateTime _stopping;

        public DateTime Starting { get; set; }
        public DateTime Stopping { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var stopwatch = new StopwatchHP();
            string userInput;
            Console.WriteLine("Press ENTER to start: ");
            userInput = Console.ReadLine();
            stopwatch.Starting = DateTime.Now;
            Console.WriteLine("Press ENTER to stop: ");
            var stopInput = Console.ReadLine();
            stopwatch.Stopping = DateTime.Now;
            TimeSpan duration = stopwatch.Stopping.Subtract(stopwatch.Starting);
            Console.WriteLine("Total time elapsed: {0}", duration);
        }
    }
}
