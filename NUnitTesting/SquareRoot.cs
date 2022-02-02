using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class SquareRoot
    {
        public void SqrtRoot()
        {
            Console.WriteLine("Enter any number: ");
            double num = Convert.ToInt32(Console.ReadLine());

            double c, t = num;

            while (true)
            {
                c = 0.5 * (t + ((double)num / t));

                if (Math.Abs(t - c) < 1)
                {
                    break;
                }

                t = c;
            }

            Console.WriteLine(c);
        }
    }
}
