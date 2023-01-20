using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    internal class POT
    {
        public POT()
        {
            Console.WriteLine(IsPowerOfTwo(9223372036854775809));
            Console.WriteLine(IsPowerOfTwo(4));
            Console.ReadLine();
        }
        static bool IsPowerOfTwo(ulong x)
        {
            return x > 0 && (x & (x - 1)) == 0;
        }
    }
}
