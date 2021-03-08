using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture.Task15
{
    class Char_N_Num
    {
        char tav;
        int num;

        public Char_N_Num(Random rnd)
        {
            tav = (char)rnd.Next(65, 91);
            num = rnd.Next(7);
        }

        public char GetTav()
        {
            return tav;
        }
        public int GetNum()
        {
            return num;
        }

        public override string ToString()
        {
            return $"Tav is '{tav}' and Num is {num} ";
        }
    }
}
