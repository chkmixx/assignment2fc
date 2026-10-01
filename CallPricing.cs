using System;

namespace assignment2fc
{
    public static class CallPricing
    {
        public static decimal CalculateCost(in CallRecord record)
        {
            if (string.IsNullOrWhiteSpace(record.RecordId) ||
                string.IsNullOrWhiteSpace(record.DestinationCountry) ||
                double.IsInfinity(record.DurationMinutes) ||
                record.DurationMinutes < 0 ||
                record.DurationMinutes > 10000)
            {
                throw new ArgumentException("Invalid call record.");
            }

            return record switch
            {
                _ when double.IsNaN(record.DurationMinutes)
                    => throw new ArgumentException("Duration cannot be NaN."),

                { IsRoaming: true, DestinationCountry: "KZ", DurationMinutes: < 1 }
                    => 50.00m,

                { IsRoaming: false, DestinationCountry: "KZ" }
                    => decimal.Round(
                        (decimal)record.DurationMinutes * 15.00m,
                        2,
                        MidpointRounding.AwayFromZero),

                { IsRoaming: true, DurationMinutes: >= 10 }
                    => decimal.Round(
                        (decimal)record.DurationMinutes * 120.00m,
                        2,
                        MidpointRounding.AwayFromZero),

                _
                    => decimal.Round(
                        (decimal)record.DurationMinutes * 45.00m,
                        2,
                        MidpointRounding.AwayFromZero)
            };
        }
    }
}