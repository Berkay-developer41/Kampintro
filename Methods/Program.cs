using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  



namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            
            double number5 = 10.4;
            decimal number6 = 10;
            char character = 'A';
            bool condition = false;
            byte number4 = 255;
            int number1 = 100005;
            long number2 = 500000;
            short number3 = 4123;
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine((int)Days.Saturday);
            Console.ReadLine();        




        }
    }
    enum Days
    {
       Monday,Tuesday,Wednesday,Thursday,Friday,Saturday    
    }
}