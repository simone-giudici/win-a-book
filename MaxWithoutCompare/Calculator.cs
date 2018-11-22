using System;
using System.Linq;

namespace MaxWithoutCompare
{
    public class Calculator
    {
        public int Max(int first, int second)
        {
            return Enumerable.Empty<int>().Append(first).Append(second).OrderByDescending(i => i).FirstOrDefault();
        }
    }
}