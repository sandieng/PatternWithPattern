using PatternWithPattern;
using PatternWithPattern.AbstractFactory;
using PatternWithPattern.Adapter;
using PatternWithPattern.Composite;
using PatternWithPattern.ConcreteClasses;
using PatternWithPattern.Decorator;
using System;

namespace StrategyAdapterDecoratorAbstractCompositeClient
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

            // Composite pattern
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(rubberDuck);

            Flock flockOfMallards = new Flock();
            flockOfMallards.Add(duckFactory.CreateMallardDuck());
            flockOfMallards.Add(duckFactory.CreateMallardDuck());
            flockOfMallards.Add(duckFactory.CreateMallardDuck());
            flockOfMallards.Add(duckFactory.CreateMallardDuck());
            flockOfMallards.Add(duckFactory.CreateMallardDuck());

            duckCall(mallardDuck);
            duckCall(redheadDuck);
            duckCall(rubberDuck);
            duckCall(goose);

            // Flock of Mallards
            Console.WriteLine("\nA flock of Mallards quacking ...");
            flockOfMallards.Quack();

            // Flock of mixed ducks
            Console.WriteLine("\nA flock of mixed ducks quacking ...");
            flockOfDucks.Quack();

            // Altogether now
            Console.WriteLine("\nEntire flock quacking ...");
            flockOfDucks.Add(flockOfMallards);
            flockOfDucks.Quack();

            Console.WriteLine($"Number of duck quacks = {QuackCounter.GetQuackCount()}");
            Console.ReadKey();
        }

        private static void duckCall(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
