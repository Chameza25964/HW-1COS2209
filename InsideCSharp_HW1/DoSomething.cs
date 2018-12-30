using System;
using System.Collections.Generic;

namespace DoSomething
{

    class FindMult
    {
        private IEnumerable<string> result;
        public FindMult(string Item) => Answer = Multiply(Item);
        public IEnumerable<string> Answer
        {
            get => result;
            set => result = value;
        }
        public static IEnumerable<string> Multiply(string Item)
        {
            float j = 1, MainNumber = float.Parse(Item);
            if (MainNumber <= 0) throw new ZeroInvalid();
            yield return $"Multiply of {MainNumber} from 1 to 12\n";
            for (; j <= 12; j++)
            {
                yield return $"{j} x {MainNumber} = {MainNumber*j}\n";
            }

            yield return "_____________End of Multiply______________";
        }
    }

    class FindFactorial
    {
        private IEnumerable<string> result;
        public FindFactorial(string Item) => Answer = Fac(Item);
        public IEnumerable<string> Answer
        {
            get => result;
            set => result = value;
        }
        public static IEnumerable<string> Fac(string Item)
        {
            float factorial = 1, MainNumber = float.Parse(Item);
            if (MainNumber < 0) throw new ZeroInvalid();
            yield return "______________Factorial___________________\n";
                while (MainNumber > 0)
                {
                    yield return $"{factorial} x {MainNumber} ";
                    factorial = factorial * MainNumber;
                    yield return $"= {factorial}\n";
                    MainNumber--;
                }
            yield return $"Factorial  is {factorial}";
        }
    }

    class ZeroInvalid : Exception
    {
        private string Punish = "Our program doesn't support a negative or zero value...";
        public override string ToString() => $"Exception: {Punish}";
    }
}

