using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class SwapNibblesNewNumber
    {
        public string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
        public string SwapNumber(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = 4; i < 3 && j < 8; i++, j++)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
        public string Change(int n)
        {


            var binary = new StringBuilder();
            while (n > 0)
            {
                
                int curr = n % 2;
                binary.Append(curr);
                n /= 2;
            }
            string temp = binary.ToString();
            int r = 8 - temp.Length;
            for (int i = 0; i < r; i++)
                temp += 0;

            temp = ReverseString(temp);
            Console.WriteLine(temp);
            string temp1 = SwapNumber(temp);
            return temp1;

        }

        public void Swap()
        {
            Console.WriteLine("Enter the number\n");
            int number = Convert.ToInt32(Console.ReadLine());
            string swapped = Change(number);
            Console.WriteLine(swapped);

        }
    }
}
