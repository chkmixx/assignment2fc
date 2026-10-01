using System;
using System.Threading;

namespace assignment2fc
{
    public static class CallProcessor
    {
        public static decimal ProcessCallsSequential(CallRecord[] records)
        {
            if (records == null)
                throw new ArgumentNullException(nameof(records));

            decimal total = 0m;

            foreach (var record in records)
            {
                total += CallPricing.CalculateCost(in record);
            }

            return total;
        }

        public static decimal ProcessCallsParallel(CallRecord[] records)
        {
            if (records == null)
                throw new ArgumentNullException(nameof(records));

            if (records.Length == 0)
                return 0m;

            if (records.Length % 2 != 0)
                throw new ArgumentException("The array length must be even.");

            int mid = records.Length / 2;

            CallRecord[] leftRecords = records[..mid];
            CallRecord[] rightRecords = records[mid..];

            decimal[] leftResults = new decimal[leftRecords.Length];
            decimal[] rightResults = new decimal[rightRecords.Length];

            Exception? leftException = null;
            Exception? rightException = null;

            Thread leftThread = new Thread(() =>
            {
                try
                {
                    for (int i = 0; i < leftRecords.Length; i++)
                    {
                        leftResults[i] = CallPricing.CalculateCost(in leftRecords[i]);
                    }
                }
                catch (Exception ex)
                {
                    leftException = ex;
                }
            });

            Thread rightThread = new Thread(() =>
            {
                try
                {
                    for (int i = 0; i < rightRecords.Length; i++)
                    {
                        rightResults[i] = CallPricing.CalculateCost(in rightRecords[i]);
                    }
                }
                catch (Exception ex)
                {
                    rightException = ex;
                }
            });

            leftThread.Start();
            rightThread.Start();

            leftThread.Join();
            rightThread.Join();

            if (leftException != null)
                throw leftException;

            if (rightException != null)
                throw rightException;

            decimal total = 0m;

            foreach (decimal cost in leftResults)
                total += cost;

            foreach (decimal cost in rightResults)
                total += cost;

            return total;
        }
    }
}