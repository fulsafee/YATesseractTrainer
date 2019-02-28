using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YATesseractTrainer
{
    public class Constants
    {
        public static int getStyle(string style)
        {
            if (style.Contains("Regular"))
                return 0;
            else if (style.Contains("Bold"))
                return 1;
            else if (style.Contains("Italic"))
                return 2;
            else
                return 0;
        }
    }
}
