using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture.Task15
{
    class SheshBesh
    {
        int dice1,dice2;
        //Random rnd = new Random();

        public SheshBesh(Random rnd)
        {
                        dice1 = rnd.Next(1,7);
            dice2 = rnd.Next(1,7);
        }
        public override string ToString()
        {
            return $"CUBE: Dice1 = {dice1} Dice2 = {dice2}; ";
        }

        public int GetDice1()
        {
            return dice1;
        }

        public int GetDice2()
        {
            return dice2;
        }
    }
}
