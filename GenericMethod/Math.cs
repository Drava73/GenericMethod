using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Math
    {
        int x, y;
        
        public void Swap<T>(ref T od1,ref T od2)
        {
            T temp = od1;
            od1 = od2;
            od2 = temp;
            Console.WriteLine($"x={od1}\ny={od2}");
        }
    }
}
