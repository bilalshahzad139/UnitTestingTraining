using AppHelper;
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
            //AppBAL.Magician magObj = new AppBAL.Magician();
            IMagicHelper obj = new MagicHelper();
            
            //Injecting the dependency from outside
            AppBAL.Magician magObj = new AppBAL.Magician(obj);
            int result = magObj.DoMagic("ABC");

            if (result == 10)
                System.Console.WriteLine("Test Passed");

            System.Console.ReadKey();
        }
    }
}
