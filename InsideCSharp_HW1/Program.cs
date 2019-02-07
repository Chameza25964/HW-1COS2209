//author: Veradeth Fedsoongnorn
//yep
using System;
using DoSomething;
using System.Collections.Generic;

namespace InsideCSharp_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> buffer;
            try
            {
                try
                {
                    if (args[1] == "m")
                    {
                        FindMult Multresult = new FindMult(args[0]);
                        buffer = Multresult.Answer;
                    }
                    else if (args[1] == "f")
                    {
                        FindFactorial Facresult = new FindFactorial(args[0]);
                        buffer = Facresult.Answer;
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
    }
}


