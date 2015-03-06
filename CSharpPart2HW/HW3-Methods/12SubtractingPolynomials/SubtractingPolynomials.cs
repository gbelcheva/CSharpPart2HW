using System;
using System.Linq;

//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

namespace _12SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input first polynomial coefficients on a single line separated by spaces. Start from highest power to lowest:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float[] coefficients1 = input.Select(x => float.Parse(x)).ToArray();
            Console.WriteLine("Input second polynomial coefficients on a single line separated by spaces. Start from highest power to lowest:");
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float[] coefficients2 = input.Select(x => float.Parse(x)).ToArray();
            Console.WriteLine("Input operation (+, -, *):");
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float[] finalPoly = new float[0];
            if (input[0] == "+")
            {
                finalPoly = AddPolys(coefficients1, coefficients2);
            }
            else if (input[0] == "-")
            {
                finalPoly = SubtractPolys(coefficients1, coefficients2);
            }
            else if (input[0] == "*")
            {
                finalPoly = MultiplyPolys(coefficients1, coefficients2);
            }
            string poly = "";
            for (int i = 0; i < finalPoly.Length - 1; i++)
            {
                if (finalPoly[i] == 0)
                {
                    continue;
                }
                poly += finalPoly[i] + "x" + (finalPoly.Length - i - 1) + " + ";
            }
            poly += finalPoly[finalPoly.Length - 1];
            poly = poly.Replace("x1 ", "x ");
            poly = poly.Replace("+ -", "- ");
            Console.WriteLine("Final polynomial is:");
            Console.WriteLine(poly);
        }

        static float[] AddPolys(float[] poly1, float[] poly2)
        {
            float[] polySum = new float[poly1.Length];
            if (poly1.Length < poly2.Length)
            {
                Array.Resize(ref poly1, poly2.Length);
                Array.Resize(ref polySum, poly2.Length);
            }
            else if (poly2.Length < poly1.Length)
            {
                Array.Resize(ref poly2, poly1.Length);
            }
            for (int i = 0; i < polySum.Length; i++)
            {
                polySum[i] = poly1[i] + poly2[i];
            }
            return polySum;
        }


        static float[] SubtractPolys(float[] num1, float[] num2)
        {
             
            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = num2[i] * (-1);
            }
            float[] polyDifference = AddPolys(num1, num2);
            return polyDifference;
        }
        static float[] MultiplyPolys(float[] num1, float[] num2)
        {

            float[] polyProduct = new float[num1.Length + num2.Length - 1];
            Array.Reverse(num2);
            Array.Reverse(num1);
            for (int j = 0; j < num2.Length; j++)
            {
                float[] tempProduct = new float[polyProduct.Length];
                for (int i = j; i < num1.Length + j; i++)
                {
                    tempProduct[i] = tempProduct[i] + (num1[i - j] * num2[j]);
                }
                polyProduct = AddPolys(polyProduct, tempProduct);
            }
            if (polyProduct[polyProduct.Length - 1] == 0)
            {
                Array.Resize(ref polyProduct, polyProduct.Length - 1);
            }
            Array.Reverse(polyProduct);
            return polyProduct;

        }
    }
}
