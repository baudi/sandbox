using System;

namespace SampleCalculator
{
    public enum Operators
    {
        Add,Rest,Mult,Div
    }

    public class Calculator
    {
        private int _total;

        public Calculator()
        {
            _total = 0;
        }

        public void DoOperation(Operators @operator, int operand)
        {
            switch (@operator)
            {
                case Operators.Add: _total += operand;
                    break;
                case Operators.Rest: _total -= operand;
                    break;
                case Operators.Mult: _total *= operand;
                    break;
                case Operators.Div: _total /= operand;
                    break;
            }
            Console.WriteLine("Total: {0,3} \t{1} {2}",
                _total, GetSymbol(@operator), operand);
        }

        private char GetSymbol(Operators @operator)
        {
            switch (@operator)
            {
                case Operators.Add: return '+';
                case Operators.Rest: return '-';
                case Operators.Mult: return '*';
                default: return '/';
            }
        }
    }
}
