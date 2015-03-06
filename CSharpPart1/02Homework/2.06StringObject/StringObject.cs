using System;

namespace _2._06StringObject
{
    class StringObject
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object objectPhrase = word1 + " " + word2;
            string stringPhrase = objectPhrase.ToString();
        }
    }
}

//Problem 6. Strings and Objects

//    Declare two string variables and assign them with Hello and World.
//    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
