using System;

namespace Delegate
{
    public class Two
    {
        private int _powResult;

        public Predicate<int> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            _powResult = powHandler.Invoke(x, y);

            return (number) => Result(number);
        }

        private bool Result(int x)
        {
            return (_powResult % x) == 0;
        }
    }
}
