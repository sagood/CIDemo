using System;

namespace MathLibrary
{
    public static class Math
    {
        public static int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
    }
}
