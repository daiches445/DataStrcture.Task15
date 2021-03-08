using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture.Task15
{
    class Domino
    {
        int[] stone = new int[2];

        public Domino(Random rnd)
        {
            stone[0] = rnd.Next(1, 7);
            stone[1] = rnd.Next(1, 7);
        }

        public void SetFirstNum(int num)
        {
            if (num > 0 && num < 7)
                stone[0] = num;
        }

        public void SetSecNum(int num)
        {
            if (num > 0 && num < 7)
                stone[0] = num;
        }

        public int GetFirstNum() { return stone[0]; }
        public int GetSecNum() { return stone[1]; }

        public bool Exist(int num)
        {
            return stone[0] == num || stone[1] == num;
        }
        public override string ToString()
        {
            return $"STONE:num1 = {stone[0]} num2 = {stone[1]}; ";
        }
    }
}
