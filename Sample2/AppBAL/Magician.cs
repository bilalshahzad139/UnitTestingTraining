using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBAL
{
    public class Magician
    {
        public int DoMagic(String param)
        {
            if (param.Equals("ABC"))
                return 10;
            else if (param.Equals("XYZ"))
                return 20;
            else
                return 30;
        }

        //public int CalculateMagicCost(int pMagicTricks)
        //{
        //    AppHelper.MagicHelper magicObj = new AppHelper.MagicHelper();
        //    if (magicObj.GetMagicComplexity(pMagicTricks) > 10)
        //        return 100;
        //    else
        //        return 50;
        //}
    }
}
