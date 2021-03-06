﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterTenYaers
{
    class AfterTenYaers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday (dd.mm.yyyy): ");
            string myBirthday = Console.ReadLine();
            DateTime myDTBirthday = DateTime.Parse(myBirthday);
            DateTime nowDT = DateTime.Now;
            int myAge = nowDT.Year - myDTBirthday.Year;
            if (nowDT.Month < myDTBirthday.Month)
            {
                myAge = myAge - 1;
            }
            else if (nowDT.Month == myDTBirthday.Month)
            {
                if (nowDT.Day < myDTBirthday.Day)
                {
                    myAge = myAge - 1;
                }
            }
            Console.WriteLine("Today, you are {0} years old.", myAge);
            Console.WriteLine("After 10 years you will be {0} years old", myAge + 10);
        }
    }
}
