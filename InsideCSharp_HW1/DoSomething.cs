using System;
using System.Collections.Generic;
using Hillarious_Function;
using Mult;
namespace DoSomething
{
    
    class FindMult : WayOfMultiply
    {
        private MathMethod.Gauge _level = MathMethod.Gauge.Normally ;
        private int[] _Range;
        private IEnumerable<string> result;
        public IEnumerable<string> Answer
        {
            get => result;
            set => result = value;
        }

        public int[] Production
        {
            get => _Range;
        }
        
        public MathMethod.Gauge Passport
        {
            get => _level;
        }

        public void UpdateGauge()
        {
            if (Production[1] >= 5000)
            {
                _level = MathMethod.Gauge.Danger;
            }
            else if(Production[1] >= 2500)
            {
                _level = MathMethod.Gauge.Caution;
            }
        }

        public FindMult(string Item) {
            _Range = new int[2];
            Answer = Multiply(Item);
           
        }
        public IEnumerable<string> Multiply(string Item)
        {
            int _Counter = 1;
            float MainNumber = float.Parse(Item);
            if (MainNumber <= 0)
                throw new ZeroInvalid();
            _Range[0] = (int)MainNumber;
            yield return $"Multiply of {MainNumber} from 1 to 12\n";
            for (; _Counter <= 12; _Counter++)
            {
                yield return $"{_Counter} x {MainNumber} = {MainNumber* _Counter}\n";
                
            }
            _Range[1] = (int)MainNumber*(_Counter-1);
            yield return "_____________End of Multiply______________\n";
            UpdateGauge();
        }
    }

    class FindFactorial : WayOfMultiply
    {
        private MathMethod.Gauge _level = MathMethod.Gauge.Normally;
        private int[] _Range;
        private IEnumerable<string> result;
        public IEnumerable<string> Answer
        {
            get => result;
            set => result = value;
        }
        public int[] Production
        {
            get => _Range;
        }

        public MathMethod.Gauge Passport
        {
            get => _level;
        }

        public FindFactorial(string Item)
        {
            _Range = new int[2];
            Answer = Fac(Item);
        }

        public void UpdateGauge()
        {
            if (Production[1] >= 5000)
            {
                _level = MathMethod.Gauge.Danger;
            }
            else if (Production[1] >= 2500)
            {
                _level = MathMethod.Gauge.Caution;
            }
        }
        public IEnumerable<string> Fac(string Item)
        {
            float Factorial = 1, MainNumber = float.Parse(Item);
            _Range[0] = (int)MainNumber;
            if (MainNumber < 0)
                throw new ZeroInvalid();
            yield return "______________Factorial___________________\n";
                while (MainNumber > 0)
                {
                    yield return $"{Factorial} x {MainNumber} ";
                    Factorial = Factorial * MainNumber;
                    yield return $"= {Factorial}\n";
                    MainNumber--;
                }
            _Range[1] = (int)Factorial;
            yield return $"Factorial  is {Factorial}\n";
            UpdateGauge();
        }
        

        
    }

    class ZeroInvalid : Exception
    {
        private string Punish = "Our program doesn't support a negative or zero value...";
        public override string ToString() => $"Exception: {Punish}";
    }
}

