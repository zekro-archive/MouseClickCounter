using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mouseCounter
{
    public static class cConst
    {
        public static string    VERSION = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static string    lableRightCounter = "Right:     ",
                                lableLeftCounter = "Left:        ",

                                versionFileURL = "https://dl.dropboxusercontent.com/s/3da7q7w39ig2vra/mouseCounter_Version.txt",
                                downloadFileURL = "https://dl.dropboxusercontent.com/s/t1alnyltkqaadfu/mouseCounter_updateURL.txt"
        ;
    }
}
