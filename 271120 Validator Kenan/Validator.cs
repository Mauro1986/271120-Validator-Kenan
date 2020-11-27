using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProgram
{
    static class Validator
    {
        public static bool IsNotZero(string value)
        {
            if (isInteger(value) == true)
                if (int.Parse(value) != 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Waarde is 0. Error");
                    return false;
                }
            else
            {
                return false;
            }
        }
        public static bool IsNotEmpty(string value)
        {
            if (value != "")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Lege string. Error.");
                return false;
            }
        }
        public static bool IsBetweenMinAndMaxInt(string value)
        {
            int min = 20;
            int max = 100;
            if (isInteger(value) == true)
                if (int.Parse(value) > min && int.Parse(value) < max)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Waarde is niet binnen de range Min en Max. Error");
                    return false;
                }
            else
            {
                return false;
            }
        }
        public static bool IsNegative(string value)
        {
            if (isInteger(value) == true)
                if (int.Parse(value) < 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Waarde is niet negatief. Error");
                    return false;
                }
            else
            {
                return false;
            }
        }
        public static bool IsPositive(string value)
        {
            if (isInteger(value) == true)
                if (int.Parse(value) > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Waarde is niet positief. Error");
                    return false;
                }
            else
            {
                return false;
            }
        }
        public static bool isInteger(string value)
        {
            if (isNumber(value) == true)
            {
                int number;
                if (Int32.TryParse(value, out number))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("No integer. Error.");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static bool isNumber(string value)
        {
            decimal number;
            if (decimal.TryParse(value, out number))
            {
                return true;
            }
            else
            {
                Console.WriteLine("No Valid Input. Error.");
                return false;
            }
        }


    }
}