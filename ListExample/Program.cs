using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            List<int> scores = new List<int>();

            while (count < numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
                count++;
            }

            scores.Sort();

            foreach (int result in scores)
            {
                Console.Write(result + " ");
            }
        }
    }
}
