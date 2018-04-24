using PatternWithPattern.ConcreteClasses;
using PatternWithPattern.Decorator;

namespace PatternWithPattern.AbstractFactory
{
    public class CountingDuckQuackFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
