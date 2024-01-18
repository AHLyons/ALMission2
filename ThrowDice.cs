using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALMission2
{
    internal class ThrowDice
    {
        public int[] RollDice(int num)
        {
            int[] rolls = new int[num];
            for (int i = 0; i < num; i++)
            {
                Random rnd = new Random();
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int rollValue = die1 + die2;

                rolls[i] = rollValue;
            }

            return rolls;
        }
    }
}
