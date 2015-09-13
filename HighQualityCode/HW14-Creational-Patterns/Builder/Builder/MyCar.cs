namespace CarExample.Builder
{
    using System;
    using System.Collections.Generic;
    using CarExample.Builder.Contracts;

    public class MyCar : ICar
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("My car was build with:");

            foreach (string part in this.parts)
            {
                Console.WriteLine("- " + part);
            }
        }
    }
}
