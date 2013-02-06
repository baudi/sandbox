using System;

namespace SampleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleMenu app = new ConsoleMenu();

                app.DoOperation(Operators.Add, 100);
                app.DoOperation(Operators.Rest, 50);
                app.DoOperation(Operators.Mult, 3);
                app.DoOperation(Operators.Div, 5);

                Console.WriteLine();
                app.Undo(4);
                Console.WriteLine();
                app.Redo(3);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
