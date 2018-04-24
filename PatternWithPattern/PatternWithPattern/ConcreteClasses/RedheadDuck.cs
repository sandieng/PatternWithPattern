using System;

namespace PatternWithPattern.ConcreteClasses
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Redhead duck says: 'Quack!'");
        }
    }
}
