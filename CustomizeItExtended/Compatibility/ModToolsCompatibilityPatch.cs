using System.Linq;
using ColossalFramework.Plugins;
//using ModTools; // 230630 Infixo

namespace CustomizeItExtended.Compatibility
{
    public class ModToolsCompatibilityPatch
    {
        public static bool IsModToolsActive()
        {
            // 230630 Infixo temp patch
            //return PluginManager.instance.GetPluginsInfo().Where(x => x.isEnabled)
                //.Any(plugin => plugin.publishedFileID.AsUInt64 == 450877484);
            return false;
        }

        public static bool AreGamePanelExtensionsActive()
        {
            // 230630 Infixo temp patch
            //return ModConfiguration.Deserialize("ModToolsConfig.xml").ExtendGamePanels;
            return false;
        }
    }
}