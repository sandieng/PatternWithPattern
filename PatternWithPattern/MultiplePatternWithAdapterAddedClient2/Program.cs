using PatternWithPattern;
using PatternWithPattern.ConcreteClasses;
using PatternWithPattern.Adapter;
using System;

namespace MultiplePatternWithAdapterAddedClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy pattern
            IQuackable mallardDuck = new MallardDuck();
            IQuackable redheadDuck = new RedheadDuck();
            IQuackable rubberDuck = new RubberDuck();

            // Adapter pattern
            IQuackable goose = new GooseAdapter(new Goose());

            duckCall(mallardDuck);
            duckCall(redheadDuck);
            duckCall(rubberDuck);
            duckCall(goose);

            Console.ReadKey();
        }

        private static void duckCall(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
