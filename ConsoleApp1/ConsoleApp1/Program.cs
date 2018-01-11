using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Computeages = new List<int> { 2, 4, 6, 8, 10, 12 };
            void CheckAges()
            {
                foreach (int item in Computeages)
                {
                    if (item == 10) return;
                }
            }
        }
    }
}
