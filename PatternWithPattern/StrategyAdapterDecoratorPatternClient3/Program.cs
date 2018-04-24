using PatternWithPattern;
using PatternWithPattern.Adapter;
using PatternWithPattern.ConcreteClasses;
using PatternWithPattern.Decorator;
using System;

namespace StrategyAdapterDecoratorPatternClient3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy pattern wrapped in Decorator pattern
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());

            // Adapter pattern
            IQuackable goose = new GooseAdapter(new Goose());

            duckCall(mallardDuck);
            duckCall(redheadDuck);
            duckCall(rubberDuck);
            duckCall(goose);

            Console.WriteLine($"Number of duck quacks = {QuackCounter.GetQuackCount()}");
            Console.ReadKey();
        }

        private static void duckCall(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
