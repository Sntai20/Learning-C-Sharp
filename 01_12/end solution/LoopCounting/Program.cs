using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            // To count up to 10 and back to 1 five times, use this for loop.
            for (int x = 1; x <= 5; x++)
            {
                // To count up to 10, use this for loop.
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // To count down from 10 to 1, use this for loop.
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
