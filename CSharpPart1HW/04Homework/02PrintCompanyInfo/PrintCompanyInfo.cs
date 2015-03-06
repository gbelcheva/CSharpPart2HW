using System;

//Problem 2. Print Company Information

//    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//    Write a program that reads the information about a company and its manager and prints it back on the console.

//Example input:
//program 	user
//Company name: 	Telerik Academy
//Company address: 	31 Al. Malinov, Sofia
//Phone number: 	+359 888 55 55 555
//Fax number: 	2
//Web site: 	http://telerikacademy.com/
//Manager first name: 	Nikolay
//Manager last name: 	Kostov
//Manager age: 	25
//Manager phone: 	+359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  


namespace _02PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            string[] companyInfo= new string[]{
                "Company name", 
                "Company address", 
                "Phone number", 
                "Fax number", 
                "Web site", 
                "Manager first name", 
                "Manager last name", 
                "Manager age", 
                "Manager phone"};
            string[] companyInfoInput = new string[companyInfo.Length];
            for (int i = 0; i < companyInfo.Length; i++)
            {
                Console.WriteLine("{0}?", companyInfo[i]);
                companyInfoInput[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(companyInfoInput[i]))
                {
                    companyInfoInput[i] = "(no " + Char.ToLowerInvariant(companyInfo[i][0]) + companyInfo[i].Substring(1) + ")";
                }
            }
            Console.WriteLine(new string('_', 20));
            Console.WriteLine();
            Console.WriteLine(companyInfoInput[0]);
            Console.WriteLine("Address: {0}", companyInfoInput[1]);
            Console.WriteLine("Tel.: {0}", companyInfoInput[2]);
            Console.WriteLine("Fax: {0}", companyInfoInput[3]);
            Console.WriteLine("Web Site: {0}", companyInfoInput[4]);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", companyInfoInput[5], companyInfoInput[6], companyInfoInput[7], companyInfoInput[8]);
        }
    }
}
