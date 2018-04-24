namespace PatternWithPattern.Decorator
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        public static int _numberOfQuack;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            _numberOfQuack++;
        }

        public static int GetQuackCount()
        {
            return _numberOfQuack;
        }
    }
}
