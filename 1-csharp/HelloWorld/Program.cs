using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            int[][] obstacles = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 0, 2},
                new int[] { 11, 22}
            };

            foreach(int[] item in obstacles)
        {
            Console.WriteLine($"obstacleY {item[0]} - obstacleX {item[1]}");
        }
        }
    }
}