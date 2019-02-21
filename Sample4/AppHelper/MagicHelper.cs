using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHelper
{
    public interface IMagicHelper
    {
        int GetMagicComplexity(int pMagicTricks);
    }
    public class MagicHelper : IMagicHelper
    {
        public int GetMagicComplexity(int pMagicTricks)
        {
            return pMagicTricks * 3 + 1;
        }
    }
}
