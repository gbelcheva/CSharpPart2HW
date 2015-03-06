using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Neurons
    {
        static void Main(string[] args)
        {
            string[] numbers = new String[32];
            int counter = 0;
            string stringInput;
            long input = 0;
            while (true)
            {
                stringInput = Console.ReadLine();
                if (stringInput == "-1")
                {
                    break;
                }
                input = Convert.ToInt64(stringInput);
                numbers[counter] = new String('1', 32);
                numbers[counter] = Convert.ToString(input, 2).PadLeft(32, '1');
                counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                char[] tempArr = numbers[i].ToCharArray();
                int j=31;
                while (true)
                {
                    if (tempArr[j] == '1')
                    {
                        break;
                    }
                    tempArr[j] = '1';
                    j--;
                }
                numbers[i] = new string(tempArr);
            }
            int number = 0;
            for (int i = 0; i < counter; i++)
            {
                number = Convert.ToInt32(numbers[i], 2);
                Console.WriteLine(~number);
            }

        }
    }
}
