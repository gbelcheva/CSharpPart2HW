using System;

//Problem 9. Play with Int, Double and String

//    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//        If the variable is int or double, the program increases it by one.
//        If the variable is a string, the program appends * at the end.
//    Print the result at the console. Use switch statement.

//Example 1:
//program 	user
//Please choose a type: 	
//1 --> int 	
//2 --> double 	3
//3 --> string 	
	
//Please enter a string: 	hello
	
//hello* 	

//Example 2:
//program 	user
//Please choose a type: 	
//1 --> int 	
//2 --> double 	2
//3 --> string 	
	
//Please enter a double: 	1.5
	
//2.5 	

namespace _09PlayIntDoubleString
{
    class PlayIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
            byte type = byte.Parse(Console.ReadLine());
            switch (type)
            {
                case 1: Console.WriteLine("Please enter an integer: "); 
                    int a = int.Parse(Console.ReadLine()) + 1; 
                    Console.WriteLine("{0}", a); 
                    break;
                case 2: Console.WriteLine("Please enter a double: "); 
                    double b = double.Parse(Console.ReadLine()) + 1; 
                    Console.WriteLine("{0}", b); 
                    break;
                case 3: Console.WriteLine("Please enter a string: "); 
                    string c = Console.ReadLine() + "*"; 
                    Console.WriteLine("{0}", c); 
                    break;
            }
        }
    }
}
