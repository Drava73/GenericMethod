using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mat1 = new Math();
            mat1.Swap<int>(ref 5,ref 6);
            mat1.Swap<string>(ref "Hello", ref "Privet");
            Console.ReadLine();
        }
    }
}
