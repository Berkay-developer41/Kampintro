using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Methotst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(30);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            //Console.WriteLine(number1);
            Console.WriteLine(result2);
            Console.ReadLine();

        }

        static int Add2(int number1=20, int number2 = 30)
        {
           var result =  number1 + number2;
            return result;
        }
    }


}
