using DDSS_UnlimitedFramerate.Utils;
using HarmonyLib;
using Il2Cpp;
using Il2CppUI.Tabs.SettingsTab;

namespace DDSS_UnlimitedFramerate.Patches
{
    [HarmonyPatch]
    internal class Patch_SettingObject
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(SettingObject), nameof(SettingObject.SetSetting))]
        private static void SetSetting_Prefix(Setting __0)
        {
            // Check for Frame Rate
            if (__0.Key == "Frame Rate")
            {
                // Add Unlimited Frame Rate
                SettingAlternative alt = __0.FindAlternativeByKey("Unlimited");
                if (alt == null)
                    __0.alternatives.Add(new("Unlimited", "Unlimited"));
            }
        }
    }
}