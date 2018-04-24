using System;

namespace PatternWithPattern.ConcreteClasses
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Mullard duck says: 'Quack!'");
        }
    }
}
