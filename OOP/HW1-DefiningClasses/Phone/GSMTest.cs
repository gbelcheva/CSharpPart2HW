namespace Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GSMTest
    {
        public static void Test()
        {
            List<GSM> phones = new List<GSM>
            {
                new GSM("One S", "HTC"),
                new GSM("E51", "Nokia", 54.99m, "MTel", new Battery("KUJHGBJH", 12, 4.5, Battery.BatteryTypeEnum.LiIon), new Display(3, 65000)),
                GSM.IPhone
            };
            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine(phones[i]);
                Console.WriteLine();
            }
        }
    }
}
