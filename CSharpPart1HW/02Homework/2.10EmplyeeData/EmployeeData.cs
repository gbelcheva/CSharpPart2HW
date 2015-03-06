using System;

namespace _2._10EmplyeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            byte age = 35;
            char gender = 'm';
            long idNumber = 8306112589L;
            int uNumber = 27564598;
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: " +
                "{2}\nGender: {3}\nID number: {4}\nUnique number: {5}",
                firstName, lastName, age, gender, idNumber, uNumber);
        }
    }
}

//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.