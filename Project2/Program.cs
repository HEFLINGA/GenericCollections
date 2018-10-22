using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollection step2 = new GenericCollection();

            step2.ListType();
            step2.LinkedType();
            step2.QueueType();
            step2.StackType();
        }
    }
}
