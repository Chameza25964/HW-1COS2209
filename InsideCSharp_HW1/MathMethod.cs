using System;
using System.Collections.Generic;


namespace Hillarious_Function
{
    class MathMethod
    {
        public enum Gauge  { Normally, Caution, Danger};

        public static void CurtainCall(int[] Number)
        {
            Console.WriteLine("End...");
        }
        public static void FindPrime(int[] Number)
        {
            int Prime=2,Upperbound=Number[Number.Length-1],Half;
            bool flag;
            if (Upperbound == 2) Prime = 1;
            for(int _count=4;_count<=Upperbound;_count++)
            {
                flag = true;
                Half = (int)(_count / 2);
                for (int _round=2;_round<=Half ; _round++)
                {
                    if (_count % _round == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) Prime++;
            }
            Console.WriteLine("From {0} to {1} Have {2} Prime Number",Number[0],Number[Number.Length-1],Prime);
        }

        public static void OddAndEven(int[] Number)
        {
            int Upperbound = Number[1],OddNumber=0,EvenNumber=0;
            for(int _round=Number[0];_round<=Upperbound;_round++)
            {
                if (_round % 2 == 0) EvenNumber++;
                else OddNumber++;
            }
            Console.WriteLine("From {0} to {1} Have {2} Even Number and {3} Odd Number", Number[0], Number[Number.Length - 1],EvenNumber,OddNumber);
        }
    }
}
