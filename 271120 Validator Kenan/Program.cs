using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorProgram
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is Integer Test: Geef een getal: ");
            string input = Console.ReadLine();
            Validator.isInteger(input);
            Console.ReadLine();

            Console.Write("Lege String test: Type iets of niets: ");
            string input2 = Console.ReadLine();
            Validator.IsNotEmpty(input2.ToString());
            Console.ReadLine();

            Console.Write("Test if NOT '0': Geef een getal: ");
            string input3 = Console.ReadLine();
            Validator.IsNotZero(input3);
            Console.ReadLine();

            Console.Write("Test if between 20 and 100: Geef een getal: ");
            string input4 = Console.ReadLine();
            Validator.IsBetweenMinAndMaxInt(input4);
            Console.ReadLine();

            Console.Write("Test if positive: Geef een getal: ");
            string input5 = Console.ReadLine();
            Validator.IsPositive(input5);
            Console.ReadLine();

            Console.Write("Test if negative: Geef een getal: ");
            string input6 = Console.ReadLine();
            Validator.IsNegative(input6);
            Console.ReadLine();

            Console.Write("Test if decimal and integer: Geef een getal: ");
            string input7 = Console.ReadLine();
            Validator.isNumber(input7);
            Console.ReadLine();
            Console.WriteLine($"Test if input {input7} is integer: ");
            Validator.isInteger(input7);
            Console.ReadLine();


        }
    }
}