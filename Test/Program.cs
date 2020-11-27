using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validatorr;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");


            string name = Console.ReadLine();
            Validator.IsNotEmpty(name);
        }
    }
}
