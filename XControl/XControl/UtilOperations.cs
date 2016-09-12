using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XControl
{
    public class UtilOperations
    {
        private static Process osk;

        public static void OpenOsk()
        {
            osk = new Process();
            osk.StartInfo.FileName = "osk.exe";

            osk.Start();
        }

        public static void CloseOsk()
        {
            if(osk == null) osk.Kill();
        }
    }
}
