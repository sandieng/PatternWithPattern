using System.Collections.Generic;

namespace PatternWithPattern.Composite
{
    public class Flock : IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
        }
    }
}
