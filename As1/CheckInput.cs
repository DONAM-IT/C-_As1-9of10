using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As1
{
    class CheckInput
    {
        public static string InputString(string msg)
        {
            string result;
            while (true)
            {
                Console.Write(msg);
                result = Console.ReadLine();
                if (result.Length == 0)
                {
                    Console.WriteLine("Please input value");
                }
                else return result;
            }
        }

        public static int InputInt(string msg)
        {
            string result;
            int num;
            while (true)
            {
                Console.Write(msg);
                result = Console.ReadLine();
                if (result.Length == 0) Console.WriteLine("Please input value");
                else
                {
                    return num = int.Parse(result);
                }
            }
        }
        public static float InputFloat(string msg)
        {
            string result;
            float price;
            while (true)
            {
                Console.Write(msg);
                result = Console.ReadLine();
                if (result.Length == 0) Console.WriteLine("Please input value");
                else
                {
                    return price = float.Parse(result);
                }
            }
        }
    }
}
