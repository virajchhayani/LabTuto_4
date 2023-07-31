using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    class A
    {
        public int x;
        public int y;
    }
    class B : A
    {
        // Field 'z' removed as it was not used
    }
    class SealedTest2
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            B sc = new B();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
