using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }

    class _10
    {
        public static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
