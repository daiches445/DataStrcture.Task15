using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrcture.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Node<int> third_item = new Node<int>(12, new Node<int>(14));
            Node<int> sec_item = new Node<int>(1, third_item);
            Node<int> item = new Node<int>(6, sec_item);
            third_item.SetNext(new Node<int>(item.GetValue()));
            Node<int> sec_item_2 = new Node<int>(2, null);

            Node<string> item_str = new Node<string>("2", null);
            Node<string> item_str2 = new Node<string>("2", null);

            Node<SheshBesh> sheshBesh = new Node<SheshBesh>(new SheshBesh(rnd));
            sheshBesh.SetNext(new Node<SheshBesh>(new SheshBesh(rnd)));
            sheshBesh.GetNext().SetNext(new Node<SheshBesh>(new SheshBesh(rnd)));

            Node<Domino> domino = new Node<Domino>(new Domino(rnd));
            domino.SetNext(new Node<Domino>(new Domino(rnd)));
            domino.GetNext().SetNext(new Node<Domino>(new Domino(rnd)));

            Node<Char_N_Num> charNnum_node = new Node<Char_N_Num>(new Char_N_Num(rnd));
            charNnum_node.SetNext(new Node<Char_N_Num>(new Char_N_Num(rnd)));
            charNnum_node.GetNext().SetNext(new Node<Char_N_Num>(new Char_N_Num(rnd)));

            Console.WriteLine("\n=========Sheshbesh========\n");
            Console.WriteLine(sheshBesh.ToString());
            Console.WriteLine("The number that got rolled most is "+MaxNumRolled(sheshBesh));

            Console.WriteLine("\n=========Domino========\n");
            Console.WriteLine("Domino Stones = "+ domino.ToString());
            Domino test_stone = new Domino(rnd);
            Console.WriteLine("Stone to attatch = "+test_stone.ToString()+"\n");
            Console.WriteLine("Can be Attached "+AttachToDominoStones(domino,test_stone)+" times");


            Console.WriteLine("\n=========Char And Num List========\n");
            Console.WriteLine("Char n num original =>" + charNnum_node+"\n");
            Console.WriteLine(MakeNewListWithDuplicates(charNnum_node));

            Console.WriteLine("\n=========Students anf Grades========\n");
            Node<Student> students = new Node<Student>(new Student("Reoven atar", 111111, 2, rnd));
            students.SetNext(new Node<Student>(new Student("Pini balili", 222222, 1, rnd)));
            students.GetNext().SetNext(new Node<Student>(new Student("Oded katash", 333333, 3, rnd)));
            students.GetNext().GetNext().SetNext(new Node<Student>(new Student("Ronen harazi", 444444, 1, rnd)));
            Console.WriteLine(students.ToString()+"\n");
            GetStudentsAVGs(students);





        }
        public static int MaxNumRolled(Node<SheshBesh> shesh)
        {
            int max = 0;
            int[] diceApperance = new int[7];

            while(!(shesh is null))
            {
                diceApperance[shesh.GetValue().GetDice1()]++;
                diceApperance[shesh.GetValue().GetDice2()]++;
                shesh = shesh.GetNext();

            }

            for (int i = 1; i < diceApperance.Length; i++)
            {
                if (diceApperance[i] > diceApperance[max])
                    max = i;
            }

            return max;
        }

        public static int AttachToDominoStones(Node<Domino> domino_stones,Domino stone)
        {
            if (domino_stones is null)
                return 0;

            if (domino_stones.GetValue().Exist(stone.GetFirstNum()) || domino_stones.GetValue().Exist(stone.GetSecNum()))
                return 1 + AttachToDominoStones(domino_stones.GetNext(), stone);
            else
                return AttachToDominoStones(domino_stones.GetNext(), stone);

        }

        public static Node<Char_N_Num> MakeNewListWithDuplicates(Node<Char_N_Num> charNnum_node)
        {
            Node<Char_N_Num> new_list = new Node<Char_N_Num>(charNnum_node.GetValue());
            Node<Char_N_Num> first = new_list;

            while (!(charNnum_node is null))
            {
                for (int i = 0; i < charNnum_node.GetValue().GetNum(); i++)
                {
                    new_list.SetNext(new Node<Char_N_Num>(charNnum_node.GetValue()));
                    new_list = new_list.GetNext();
                }

                charNnum_node = charNnum_node.GetNext();
            }

            return first.GetNext();

        }

        public static void GetStudentsAVGs(Node<Student> stud_list)
        {
            
            string output = "";

            while(!(stud_list is null))
            {
                int gradesTotal = 0, count = 0;
                Node<Grade> grades = stud_list.GetValue().GetGrades();
                while (!(grades is null))
                {
                    gradesTotal += grades.GetValue().GetGrade();
                    count++;
                    grades = grades.GetNext();
                }
                output += $"{stud_list.GetValue().GetName()} has a avarge of {(double)gradesTotal / count}\n";
                stud_list = stud_list.GetNext();
            }

            Console.WriteLine(output);
        }
    }
}
