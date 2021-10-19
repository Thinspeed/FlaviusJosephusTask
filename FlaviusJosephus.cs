using System;
using System.Collections.Generic;
using System.Text;

namespace FlaviusJosephusTask
{
    public static class FlaviusJosephus
    {
        public static int Solve(int playersNumber, int number)
        {
            if (playersNumber <= 0)
            {
                throw new ArgumentException($"{nameof(playersNumber)} can not be less or equal 0");
            }

            if (number <= 0)
            {
                throw new ArgumentException($"{nameof(number)} can not be less or equal 0");
            }

            var players = new LinkedList<int>();
            for (int i = 0; i < playersNumber; i++)
            {
                players.AddLast(i);
            }

            LinkedListNode<int> current = null;
            while (players.Count != 1)
            {
                for (int i = 0; i < number; i++)
                {
                    if (current == null)
                    {
                        current = players.First;
                    }
                    else
                    {
                        current = current.Next;
                    }                    
                }

                if (current == null)
                {
                    current = players.First;
                }

                var prev = current.Previous;
                Console.WriteLine(current.Value);
                players.Remove(current);
                current = prev;
            }

            return players.Last.Value;
        }

    }
}
