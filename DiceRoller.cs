using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission02
{
    internal class DiceRoller
    {
        private Random r = new Random();
        public int[] RollDice(int rolls)
        {
            int[] results = new int[11];

            for (int i = 0; i < rolls; i++)
            {
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);

                int sum = dice1 + dice2;
                results[sum - 2]++;
            }

            return results;

        }
    }
}
