using System;
using System.Threading;
using System.Globalization;

//Problem 2. Gravitation on the Moon

//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

//Examples:
//weight 	weight on the Moon
//86 	14.62
//74.6 	12.682
//53.7 	9.129

namespace _02MoonGravitation
{
    class MoonGravitation
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input weight:");
            float weightEarth = float.Parse(Console.ReadLine());
            float weightMoon = 0.17f * weightEarth;
            Console.WriteLine("Weight on the Moon:\n{0}", weightMoon);
        }
    }
}
