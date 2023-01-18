using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class RollCounter
    {
        int numRolls;
        int value = 2;

        public RollCounter()
        {
            value++;
        }

        public void RollDice()
        {
            numRolls++;
        }
    }


}
