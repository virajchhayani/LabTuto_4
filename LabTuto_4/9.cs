using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    internal class _9
    {
        public static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            int x = 0;
            try
            {
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
