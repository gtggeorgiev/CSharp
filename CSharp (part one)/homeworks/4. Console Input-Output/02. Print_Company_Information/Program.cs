//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            //Company name
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();

            //Company address
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();

            //Phone number
            Console.Write("Enter phone number: ");
            string strPhoneNumber = Console.ReadLine();
            long phoneNumber = long.Parse(strPhoneNumber);

            //Fax number
            Console.Write("Enter fax number: ");
            string strFaxNumber = Console.ReadLine();
            int faxNumber = int.Parse(strFaxNumber);

            //Web site
            Console.Write("Enter web site: ");
            string webSite = Console.ReadLine();

            //Manager first name
            Console.Write("Enter manager's first name: ");
            string managerFirstName = Console.ReadLine();

            //Manager last name
            Console.Write("Enter manager's last name: ");
            string managerLastName = Console.ReadLine();

            //Manager age
            Console.Write("Enter manager's age: ");
            string strManagerAge = Console.ReadLine();
            byte managerAge = byte.Parse(strManagerAge);

            //Manager phone
            Console.Write("Enter manager's phone: ");
            string strManagerPhone = Console.ReadLine();
            long namagerPhone = long.Parse(strManagerAge);

            //Output
            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine(companyAddress);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(faxNumber);
            Console.WriteLine(webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel.{3})",
                                managerFirstName, managerLastName, strManagerAge, strManagerPhone);
        }
    }
}
