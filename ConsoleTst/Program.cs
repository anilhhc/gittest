using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTst;
namespace ConsoleTst
{
    class Program:Class1
    {
        static void Main(string[] args)
        {
            object obj;
            obj = 100;
            dynamic d = 20;
            
            string str = "something";
            Console.WriteLine(str);
            Console.WriteLine("obj value {0}", obj);
            Console.ReadLine();
        }
    }
}
