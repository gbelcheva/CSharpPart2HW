namespace Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM htc = new GSM("One S", "HTC");
            htc.AddCall(new Call(new DateTime(2015, 02, 01, 14, 52, 02), "+359886645879", new TimeSpan(0, 5, 20)));
            htc.AddCall(new Call(new DateTime(2015, 02, 03, 18, 20, 02), "+359886645879", new TimeSpan(0, 45, 2)));
            //htc.AddCall(new Call(new DateTime(2015, 02, 03, 18, 10, 02), "+359886645800", new TimeSpan(0, 45, 2)));
            htc.AddCall(new Call(new DateTime(2015, 02, 20, 10, 10, 55), "+359884865849", new TimeSpan(0, 3, 10)));
            foreach (var call in htc.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("Total price: {0}", htc.CalcTotalPrice(0.37M).ToString("C", new System.Globalization.CultureInfo("en-US")));
            var longestCallDuration = htc.CallHistory.Max(c => c.Duration);
            List<Call> longestCalls = htc.CallHistory.Where(c => c.Duration == longestCallDuration).ToList();
            foreach (var call in longestCalls)
            {
                htc.DeleteCall(call);
            }
            foreach (var call in htc.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("Total price: {0}", htc.CalcTotalPrice(0.37M).ToString("C", new System.Globalization.CultureInfo("en-US")));
            htc.ClearHistory();
            foreach (var call in htc.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
