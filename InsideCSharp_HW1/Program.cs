//author: Veradeth Fedsoongnorn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideCSharp_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[1]=="m")
            {
                DoSomething.FindMult.Multiply(args[0]);
            }
            else if(args[1]=="f")
            {
                DoSomething.FindFactorial.Fac(args[0]);
            }
            else
            {
                Console.WriteLine("So sad.. Your argument doesn't match with any work in our function,Please Try again with 'm' or 'f' ");
            }
            
        }
    }
}

namespace DoSomething
{
    class FindMult
    {
        public static void Multiply(string Item)
        {
            float MainNumber = float.Parse(Item), j = 1;
            Console.WriteLine("Multiply of {0} from 1 to 12", MainNumber);
                for (; j <= 12; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", j, MainNumber, MainNumber * j);
                }
            
            Console.WriteLine("_____________End of Multiply______________");
        }
    }

    class FindFactorial
    {
        public static void Fac(string Item)
        {
            float factorial = 1,MainNumber=float.Parse(Item);
            Console.WriteLine("______________Factorial___________________");
            if(MainNumber <= 0)
            {
                Console.WriteLine("Because the number is negative or zero.");
            }
            else
            {
                while(MainNumber > 0)
                {
                    Console.Write("{0} x {1} ",factorial, MainNumber);
                    factorial = factorial * MainNumber;
                    Console.WriteLine("= {0}", factorial);
                    MainNumber--;
                }
            }
            Console.WriteLine("Factorial  is {0}", factorial);
            Console.WriteLine("_____________End Factorial____________");
        }
    }
}