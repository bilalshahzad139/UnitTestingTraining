using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBAL.Magician magObj = new AppBAL.Magician();
            int result = magObj.DoMagic("ABC");

            if (result == 10)
                System.Console.WriteLine("Test Passed");

            System.Console.ReadKey();
        }
    }
}
