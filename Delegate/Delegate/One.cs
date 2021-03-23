using System;

namespace Delegate
{
    public class One
    {
        public Action<bool> ShowHandler { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
