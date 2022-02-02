using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        double principle = 0, rate = 0, noOfYears = 0;

        public double ReturnResult(double principle, double rate, double noOfYears)
        {
            double n = 12 * noOfYears;
            double r = rate / (12 * 100);

            double ans = (principle * r) / 1 - (Math.Pow((1 + r), 1 / n));
            return ans;
        }
        public void CalMonthlyPayment()
        {
            Console.WriteLine("Enter the principle amount: ");
            principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest: ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the no of years: ");
            noOfYears = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Monthly Payment user need to do is Rs. " + ReturnResult(principle, rate, noOfYears));
        }
    }
}
