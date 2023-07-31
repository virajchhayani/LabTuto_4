using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    class StaticVar
    {
        public static int num;
        public void counting()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            StaticVar s = new StaticVar();
            s.counting(); // Use the 'counting()' method on the 's' instance
            s.counting();
            s.counting();
            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
