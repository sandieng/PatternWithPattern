using System;

namespace PatternWithPattern.ConcreteClasses
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Rubber duck says: 'Kwack!'");
        }
    }
}
