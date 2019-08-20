using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Harmony;

namespace Invisa_Armband
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            try
            {
                HarmonyInstance hInstance = HarmonyInstance.Create("Lobotomy.Watson & NEET.Invisa-Armband");
                hInstance.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception excep)
            {
                FileLog.Log("Invisa_Armband Patching Threw an Exception... " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                FileLog.Log(excep.ToString());
                FileLog.Log(excep.Message);
                FileLog.Log(excep.TargetSite.Name);
            }
        }
    }
}
