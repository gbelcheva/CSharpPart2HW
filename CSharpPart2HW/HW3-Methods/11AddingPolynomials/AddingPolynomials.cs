using System;
using System.Linq;
using System.Text;

//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:

//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

namespace _11AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input first polynomial coefficients on a single line separated by spaces. Start from highest power to lowest:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float[] coefficients1 = input.Select(x => float.Parse(x)).ToArray();
            Console.WriteLine("Input second polynomial coefficients on a single line separated by spaces. Start from highest power to lowest:");
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float[] coefficients2 = input.Select(x => float.Parse(x)).ToArray();
            float[] finalPoly = AddPolys(coefficients1, coefficients2);
            //Array.Reverse(finalPoly);
            string poly = "";
            for (int i = 0; i < finalPoly.Length - 1; i++)
            {
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
    }
}
