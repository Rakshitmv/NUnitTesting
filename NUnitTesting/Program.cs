using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: To get Day of the week\n" + "Enter 2: Vending Machine\n" +  "Enter 3: Temperature Conversion\n" + "Enter 4: Monthly Payment\n" + "Enter 5: Square Roots\n" + "Enter 6: Get decimal to binary\n" + "Enter 7: Swap nibbles\n" + "Enter 8: Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DayOfWeek.Input();
                        break;
                    case 2:
                        VendingMachine machine = new VendingMachine();
                        machine.Change();
                        break;
                    case 3:
                        TemperatureConversion temperatureConversion = new TemperatureConversion();
                        temperatureConversion.ConvertTemperature();
                        break;
                    case 4:
                        MonthlyPayment payment = new MonthlyPayment();
                        payment.CalMonthlyPayment();
                        break;
                    case 5:
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.SqrtRoot();
                        break;
                    case 6:
                        ToBinary toBinary = new ToBinary();
                        toBinary.Binary();
                        break;
                    case 7:
                        SwapNibblesNewNumber swapNibblesNewNumber = new SwapNibblesNewNumber();
                        swapNibblesNewNumber.Swap();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct option\n");
                        break;


                }

            }
        }
    }
}
