﻿using HarmonyLib;
using Il2CppDefaultNamespace;

namespace DDSS_UnlimitedFramerate.Patches
{
    [HarmonyPatch]
    internal class Patch_SettingsManager
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.GetSettingChoice))]
        private static void GetSettingChoice_Postfix(string __0, ref string __result)
        {
            if (__0 != "Frame Rate")
                return;

            if (__result == "Unlimited")
                __result = "-1";
        }
    }
}