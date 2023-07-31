using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    class X
    {
        public virtual void F() { Console.WriteLine("X.F"); }
        public virtual void F2() { Console.WriteLine("X.F2"); }
    }
    class Y : X
    {
        public override void F() { Console.WriteLine("Y.F"); }
        public override void F2() { Console.WriteLine("Y.F2"); }
    }
    class Z : Y
    {
    }

    class SealedMethodTest
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Y Obj2 = new Y();
            Obj2.F();
            Obj2.F2();
            Z Obj3 = new Z();
            Obj3.F();
            Obj3.F2();
        }
    }
}
