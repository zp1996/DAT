using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[] { 3, 6, 9, 2, 4, 7, 1, 8, 5 };
            TrainRoad x = new TrainRoad(3, 3);
            x.Railroad(p);
        }
    }
}
