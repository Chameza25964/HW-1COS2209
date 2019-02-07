//author: Veradeth Fedsoongnorn
//yep
using System;
using DoSomething;
using System.Collections.Generic;
using Hillarious_Function;
using Mult;
namespace InsideCSharp_HW1
{
    class Program
    {
        public delegate void MathFunc(int[] Number);
        static void Main(string[] args)
        {
            IEnumerable<string> buffer;
            int[] _Numeric;
            MathFunc Caller;
            Object Sub;
            try
            {
                try
                {
                    if (args[1] == "m")
                    {
                        FindMult Multresult = new FindMult(args[0]);
                        _Numeric = Multresult.Production;
                        buffer = Multresult.Answer;
                        Sub = Multresult;
                    }
                    else if (args[1] == "f")
                    {
                        FindFactorial Facresult = new FindFactorial(args[0]);
                        _Numeric = Facresult.Production;
                        buffer = Facresult.Answer;
                        Sub = Facresult;
                        
                    }
                    else
                    {
                        Console.WriteLine("So sad.. Your argument doesn't match with any work in our function,Please Try again with 'm' or 'f' ");
                        return;
                    }
                    foreach (var eachresult in buffer)
                    {
                        Console.Write(eachresult);
                    }
                    AssignFunc((WayOfMultiply)Sub, out Caller);
                    Caller(_Numeric);
                    
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("This Program need an arguments,Please put an argument more than 1");
                }
            }
            catch(ZeroInvalid z)
            {
                Console.WriteLine(z);
            }
        }

        public static void AssignFunc(WayOfMultiply SomeObject,out MathFunc Client)
        {
            Client = MathMethod.CurtainCall;
            if(SomeObject.Passport==MathMethod.Gauge.Danger)
            {
                Console.WriteLine("This Object was feed too much data,So there are no function to assign for this Object");
            }
            else if (SomeObject.Passport==MathMethod.Gauge.Caution)
            {
                Client += MathMethod.OddAndEven;
            }
            else
            {
                Client += MathMethod.OddAndEven;
                Client += MathMethod.FindPrime;
            }
        }
    }
}


