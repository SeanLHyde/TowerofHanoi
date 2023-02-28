using System;
using System.Diagnostics;

namespace TowerOfHanoiNew
{
    class Program
    {
        public static void Main(String[] args)
        {
            int numberOfDisks;
            Console.Write("Number of disks = ");
            numberOfDisks = Convert.ToInt32(Console.ReadLine());
            char startRod = 'A';
            char tempRod = 'B';
            char endRod = 'C';
            Stopwatch sw = new Stopwatch();
            sw.Start();

            TowerOfHanoiNew(numberOfDisks, startRod, tempRod, endRod);
            
            sw.Stop();
            Console.WriteLine("Computation time = " + sw.ElapsedMilliseconds + " milliseconds");
        }

        private static void TowerOfHanoiNew(int n, char startRod, char tempRod, char endRod)
        {
            if (n > 0)
            {
                TowerOfHanoiNew(n - 1, startRod, endRod, tempRod);
                Console.WriteLine("Move top disk from " + startRod + ' ' + endRod);
                TowerOfHanoiNew(n - 1, tempRod, startRod, endRod);
            }
        }
    }
}