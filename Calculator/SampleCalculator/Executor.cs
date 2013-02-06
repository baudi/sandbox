namespace SampleCalculator
{
    public interface IExecutor
    {
        void Execute();
        void UnExecute();
    }

    public class Executor : IExecutor
    {
        private readonly Calculator _calculator;
        private readonly Operators _operator;
        private readonly int _operand;

        public Executor(Calculator calculator, Operators @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.DoOperation(_operator, _operand);
        }

        public void UnExecute()
        {
            _calculator.DoOperation(GetOpposite(_operator), _operand);
        }

        private Operators GetOpposite(Operators @operator)
        {
            switch (@operator)
            {
                case Operators.Add: return Operators.Rest;
                case Operators.Rest: return Operators.Add;
                case Operators.Mult: return Operators.Div;
                default: return Operators.Mult;
            }
        }
    }
}
