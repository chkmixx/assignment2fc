using System;

namespace assignment2fc
{
    class Program
    {
        static void Main()
        {
            CallRecord[] records =
            {
                new CallRecord("001", "KZ", 4, false),
                new CallRecord("002", "KZ", 0.5, true),
                new CallRecord("003", "US", 10, true),
                new CallRecord("004", "DE", 3, false),
                new CallRecord("005", "XX", 2, false),
                new CallRecord("006", "KZ", 1, true)
            };

            decimal sequentialTotal =
                CallProcessor.ProcessCallsSequential(records);

            decimal parallelTotal =
                CallProcessor.ProcessCallsParallel(records);

            Console.WriteLine($"Sequential total: {sequentialTotal:F2}");
            Console.WriteLine($"Parallel total:   {parallelTotal:F2}");

            Console.WriteLine(
                $"Results match: {sequentialTotal == parallelTotal}");
        }
    }
}