using PatternWithPattern.ConcreteClasses;

namespace PatternWithPattern.Adapter
{
    public class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }
    }
}
