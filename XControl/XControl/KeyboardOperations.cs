using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XControl
{
    public class KeyboardOperations
    {
        public static void PressDirection(String direction)
        {
            SendKeys.Send("{" + direction.ToUpper() + "}");
        }
    }
}
