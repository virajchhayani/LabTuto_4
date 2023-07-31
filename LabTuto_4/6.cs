﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    abstract class Test
    {
        protected int a;
        public Test()
        {
            a = 0;
        }
        public abstract void A();
    }
    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");
            a++;
        }
    }
    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");
            a--;
        }
    }
    class _6
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            Test test1 = new Example1();
            test1.A();
            Test test2 = new Example2();
            test2.A();
        }
    }
}
