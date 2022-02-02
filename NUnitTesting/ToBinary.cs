using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class ToBinary
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
        public void Binary()
        {
            Console.WriteLine("Enter the number\n");
            int n = Convert.ToInt32(Console.ReadLine());
            var binary = new StringBuilder();
            while (n > 0)
            {
               
                int current = n % 2;
                binary.Append(current);
                n /= 2;
            }
            Console.WriteLine(binary.Length);
            string temp = binary.ToString();
            Console.WriteLine(ReverseString(temp));

        }
    }
}
