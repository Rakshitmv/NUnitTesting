using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class TemperatureConversion
    {

        public double CalResult(string inpUnit, double val)
        {
            double ans = 0;
            if (inpUnit.Equals("Celcius"))
            {
                ans = ((val * (double)9 / 5) + 32);
            }
            if (inpUnit.Equals("Farenheit"))
            {
                ans = (val - 32) * (double)5 / 9;
            }
            return ans;
        }
        public void ConvertTemperature()
        {
            Console.WriteLine("\nEnter\n1 for Celcius to Farenheit conversion\n" +
                "2 for Farenheit converion\n");

            Console.WriteLine("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value : ");
            double val = Convert.ToDouble(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"{val}°C = " + CalResult("Celcius", val) + " °F");
                    break;

                case 2:
                    Console.WriteLine($"{val}°F = " + CalResult("Farenheit", val) + "°C");
                    break;

                default:
                    Console.WriteLine("Please enter correct option");
                    break;

            }
        }
    }
}
