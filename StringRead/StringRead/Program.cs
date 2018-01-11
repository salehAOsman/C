using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string frstStr   = "The quick fox Jumped Over the DOG";
            string secondStr = "The brown fox jumped over the lazy dog";
            Console.WriteLine("Input new string :");
            string inStr= Console.ReadLine();
            ComparStr(inStr);
        }
        static void ComparStr(string inStr)
        {
            //string inString = instr;
            string lastInWord = "";
            string thred = "        ";

            foreach (int item in inStr)
                {
                   // lastInWord = instr[item];
                    if (inStr[item].ToString() != lastInWord)
                    {
                        thred.Insert(item, inStr[item].ToString());
                    }
                else
                {
                    Console.WriteLine("there is error");
                }
                }
            
            Console.WriteLine("first word is : "+ thred);
            Console.ReadKey();

        }
    }
}
