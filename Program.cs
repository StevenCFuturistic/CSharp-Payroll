using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/* Book: Microsoft Visual C# 2015: An Introduction to Object Oriented Programming
17.Write a program named Payroll that prompts the user for a name, Social Security number, hourly pay rate, and number of hours worked. In an attractive format (similar to Figure 2-23), display all the input data as well as the following: •gross pay, defined as hourly pay rate times hours worked •federal withholding tax, defined as 15 percent of the gross pay •state withholding tax, defined as 5 percent of the gross pay •net pay, defined as gross pay minus taxes
Farrell, Joyce. Microsoft Visual C# 2015: An Introduction to Object-Oriented Programming (Page 98). Course Technology. Kindle Edition. */
// Author: Steven C Love 3/24/2019
namespace Payroll
{
    class Program
    {
        static void Main(string[] args)

        // variables
        {
            string name, SSN, hoursWorkedAsString, hourlyPayRateAsString;
            int hoursWorked;
            double hourlyPayRate;
            double grossPay, federalWithholdingTax, stateWithholdingTax, netPay;


            Write(" Enter your name: >> \n");
            name = ReadLine();
            Write(" Enter your Social Security Number: \n");
            SSN = ReadLine();
            Write(" Payroll Summary for: {0}: \n " + " Social Security Number: {1} \n", name, SSN);
            Write(" Enter your hours worked: >> \n");
            hoursWorkedAsString = ReadLine();
            hoursWorked = Convert.ToInt32(hoursWorkedAsString);
            Write(" Enter your hourly pay rate: >> \n");
            hourlyPayRateAsString = ReadLine();
            hourlyPayRate = Convert.ToDouble(hourlyPayRateAsString);
            Write(" You worked: {0} " + " hours." + " at {1} " + " an hour. \n", hoursWorked, hourlyPayRate.ToString("C2"));
            Write("------------------------------------------------------------- \n");

            grossPay = hoursWorked * hourlyPayRate;

            Write(" Your Gross Pay is: {0} \n", grossPay.ToString("C2"));

            federalWithholdingTax = grossPay * .15;

            Write("Federal Income Tax Witheld: {0} \n", federalWithholdingTax.ToString("C2"));

            stateWithholdingTax = grossPay * .05;

            Write("State Withholding Tax Withheld: {0} \n", stateWithholdingTax.ToString("C2"));


            netPay = grossPay - federalWithholdingTax - stateWithholdingTax;


            Write(" Your net pay is : {0} \n", netPay.ToString("C2"));

       









            Console.ReadKey();
        }
    }
}
