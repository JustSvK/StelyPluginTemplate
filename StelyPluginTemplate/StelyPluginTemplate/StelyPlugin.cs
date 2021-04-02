using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StelyPluginTemplate
{
    //Hello, this is the plugins tab!
    //Here you can basically create your own plugin, which will work for Stely!
    //So, you can code here basically everything, just do not change
    //The class name(StelyPlugin) or the void name(Main)
    //Btw, everything which is in Main will get only executed, so when you create new method, make sure to call it in there!
    //-JustSvK
    public class StelyPlugin
    {
        public static void Main()
        {
            MessageBox.Show("Hello from plugins!");
        }
    }
}
