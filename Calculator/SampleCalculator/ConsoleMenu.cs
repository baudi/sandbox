using System;
using System.Collections.Generic;

namespace SampleCalculator
{
    public class ConsoleMenu
    {
        private Calculator _calculator;
        private List<IExecutor> _entries;
        private int _index;

        public ConsoleMenu()
        {
            _calculator = new Calculator();
            _entries = new List<IExecutor>();
            _index = 0;
        }

        public void DoOperation(Operators @operator, int operand)
        {
            Executor command = new Executor(_calculator, @operator, operand);
            command.Execute();
            _index = _entries.Count;
            _index++;
            _entries.Add(command);
        }

        public void Undo(int levels)
        {
            Console.WriteLine("--- Undo {0} levels.", levels);
            for (int i = 0; i < levels; i++)
            {
                if (_index > 0)
                {
                    IExecutor command = _entries[--_index];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            Console.WriteLine("--- Redo {0} levels", levels);
            for (int i = 0; i < levels; i++)
            {
                if (_index < _entries.Count - 1)
                {
                    IExecutor command = _entries[_index++];
                    command.Execute();
                }
            }
        }
    }
}
