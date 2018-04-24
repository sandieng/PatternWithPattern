using PatternWithPattern.ConcreteClasses;

namespace PatternWithPattern.AbstractFactory
{
    public class NormalDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
