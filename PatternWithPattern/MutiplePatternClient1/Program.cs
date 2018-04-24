using PatternWithPattern;
using PatternWithPattern.ConcreteClasses;
using System;

namespace MutiplePatternClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy pattern
            IQuackable mallardDuck = new MallardDuck();
            IQuackable redheadDuck = new RedheadDuck();
            IQuackable rubberDuck = new RubberDuck();

            duckCall(mallardDuck);
            duckCall(redheadDuck);
            duckCall(rubberDuck);

            Console.ReadKey();
        }

        private static void duckCall(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
