using System;
using System.Collections.Generic;
class Enigmanation
{
    static double CalcBrackets(string expr)
    {
        char[] expression = expr.ToCharArray();
        double result = expression[0] - '0';

        for (int i = 2; i < expression.Length; i += 2)
        {
            if (expression[i - 1] == '+') result += (expression[i] - '0');
            else if (expression[i - 1] == '-') result -= (expression[i] - '0');
            else if (expression[i - 1] == '%') result %= (expression[i] - '0');
            else if (expression[i - 1] == '*') result *= (expression[i] - '0');
        }
        return result;
    }
    static void Main()
    {
        string entry = Console.ReadLine();
        char[] input = entry.ToCharArray();
        List<string> list = new List<string>();

        double result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                int endInBracketIndex = entry.IndexOf(')', i);
                string insideBrackets = entry.Substring(i + 1, endInBracketIndex - i - 1);
                list.Add(CalcBrackets(insideBrackets).ToString());
                i = endInBracketIndex;
            }
            if (input[i] == ')') i += 1;
            list.Add(input[i].ToString());
        }

        result = double.Parse(list[0]);
        for (int i = 2; i < list.Count; i++)
        {
            if (list[i - 1] == "+") result += double.Parse(list[i]);
            else if (list[i - 1] == "-") result -= double.Parse(list[i]);
            else if (list[i - 1] == "%") result %= double.Parse(list[i]);
            else if (list[i - 1] == "*") result *= double.Parse(list[i]);
        }
        Console.WriteLine("{0:f3}", result);
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string expression = Console.ReadLine();
//            expression = expression.Remove(expression.Length - 1);
//            string reducedExp = "";
//            string expressionBrackets = "";
//            int i = 0;
//            while  (i < expression.Length)
//            {
//                if (expression[i] == '(')
//                {
//                    while (expression[i + 1] != ')')
//                    {
//                        expressionBrackets = expressionBrackets + expression[i + 1];
//                        i++;
//                    }
//                    string[] splitBrackets = expressionBrackets.Split(new Char[] { '(', ')', '+', '-', '*', '%' });
//                    reducedExp = reducedExp + CalculateExpression(expressionBrackets, splitBrackets).ToString();
//                    if (i + 2 < expression.Length) 
//                    {
//                        reducedExp = reducedExp + expression[i + 2];
//                    }
//                    expressionBrackets = "";
//                    i += 3;
//                    continue;
//                }
//                else
//                {
//                    while (expression[i] != '(')
//                    {
//                        reducedExp = reducedExp + expression[i];
//                        i++;
//                        if (i >= expression.Length)
//                        {
//                            break;
//                        }
//                    }
//                }
//            }
//            string[] split = reducedExp.Split(new Char[] { '(', ')', '+', '-', '*', '%' });
//            Console.WriteLine("{0:N3}", CalculateExpression(reducedExp, split));
//        }


//        static int CalculateExpression(string expression, string[] numbers)
//        {

//            int result = Convert.ToInt32(numbers[0]);
//            int resultFinal = 0;
//            char sign = '+';
//            int j = 1;
//            for (int i = 0; i < expression.Length - 1; i++)
//            {
//                if (!Char.IsDigit(expression[i + 1]))
//                {
//                    result = Calculate(result, Convert.ToInt32(numbers[j]), expression[i + 1]);
//                    j++;
//                }
//            }
//            return resultFinal = Calculate(resultFinal, result, sign);
//        }

//        //static int CalculateExpression(string expression, string[] numbers)
//        //{

//        //    int result = Convert.ToInt32(numbers[0]);
//        //    int resultFinal = 0;
//        //    char sign = '+';
//        //    int j = 1;
//        //    for (int i = 0; i < expression.Length - 1; i++)
//        //    {
//        //        if (expression[i + 1] != '+' && expression[i + 1] != '-' && !Char.IsDigit(expression[i + 1]))
//        //        {
//        //            result = Calculate(result, Convert.ToInt32(numbers[j]), expression[i + 1]);
//        //            j++;
//        //        }
//        //        else if (!Char.IsDigit(expression[i + 1]))
//        //        {
//        //            resultFinal = Calculate(resultFinal, result, sign);
//        //            result = Convert.ToInt32(numbers[j]);
//        //            j++;
//        //            sign = expression[i + 1];
//        //        }
//        //    }
//        //    return resultFinal = Calculate(resultFinal, result, sign);
//        //}

//        static int Calculate(int a, int b, char operation) 
//        {
//            int result = a;
//            switch (operation)
//            {
//                case '%': result = a % b; break;
//                case '*': result = a * b; break;
//                case '+': result = a + b; break;
//                case '-': result = a - b; break;
//                default: break;
//            }
//            return result;
//        }
//    }
//}
