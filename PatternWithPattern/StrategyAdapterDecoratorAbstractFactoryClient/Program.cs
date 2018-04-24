using PatternWithPattern;
using PatternWithPattern.AbstractFactory;
using PatternWithPattern.Adapter;
using PatternWithPattern.ConcreteClasses;
using PatternWithPattern.Decorator;
using System;

namespace StrategyAdapterDecoratorAbstractFactoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Factory
            AbstractDuckFactory duckFactory = new CountingDuckQuackFactory();

            // Abstract factory to create Strategy pattern wrapped in Decorator pattern
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

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
