using System;

namespace Delegate
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var one = new One();
            one.ShowHandler = Show;
            var two = new Two();
            var calcResult = two.Calc(one.Pow, 10, 10);
            var result = calcResult(5);
            one.ShowHandler(result);
        }

        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
