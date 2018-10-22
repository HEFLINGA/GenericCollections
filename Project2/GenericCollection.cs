using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class GenericCollection
    {
        public void ListType()
        {
            List<int> listvs = new List<int>();
            foreach (int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                listvs.Add(num);
            }
            Console.WriteLine("----------List----------");
            for (int i = 0; i < listvs.Count; i++)
            {
                int num = listvs[i];
                Console.WriteLine(num);
            }
            Console.WriteLine("");
        }
        public void LinkedType()
        {
            LinkedList<string> listvs = new LinkedList<string>();
            Console.WriteLine("---------LinkedList----------");
            foreach (string str in new string[5] { "First", "Second", "Third", "Fourth", "Fifth" })
            {
                listvs.AddFirst(str);
            }
            foreach (string str in listvs)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");
        }
        public void QueueType()
        {
            Queue<int> queuevs = new Queue<int>();
            Console.WriteLine("----------Queue----------");
            foreach (int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                queuevs.Enqueue(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("");
        }
        public void StackType()
        {
            Console.WriteLine("--------Stack--------");
            Stack<string> stackvs = new Stack<string>();
            foreach (var str in new string[5] { "FirstNum", "SecondNum", "ThirdNum", "FourthNum", "FifthNum"})
            {
                stackvs.Push(str);
            }
            foreach (var str in stackvs)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");
        }
    }
}
