using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13AvgLoadTime
{
    class AvgLoadTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC when finished enetering data.\n");
            List<string> data = new List<string>();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                data.Add(Console.ReadLine());
            }
            List<KeyValuePair<string, double>> URLAndTime = new List<KeyValuePair<string, double>>();
            //Dictionary<string, double> URLAndTime = new Dictionary<string, double>();
            for (int i = 0; i < data.Count; i++)
            {
                string[] dataPieces = data[i].Split(' ');
                URLAndTime.Add(new KeyValuePair<string, double>(dataPieces[2], Convert.ToDouble(dataPieces[3])));
            }
            double avg = 0;
            double counter = 0;
            int j = 0;
            string[] used = new string[data.Count];
            bool isUsed = false;
            foreach (var set1 in URLAndTime)
            {
                for (int i = 0; i < used.Length; i++)
                {
                    if (set1.Key == used[i])
                    {
                        isUsed = true;
                        break;
                    }
                }
                if (!isUsed)
                {
                    foreach (var set2 in URLAndTime)
                    {
                        if (set1.Key == set2.Key)
                        {
                            avg = avg + set2.Value;
                            counter++;
                        }
                    }
                    avg = avg / counter;
                    Console.WriteLine("{0} -> {1}", set1.Key, avg);
                }
                used[j] = set1.Key;
                j++;
                counter = 0;
                avg = 0;
                isUsed = false;
            }
        }
    }
}
