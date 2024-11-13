using HarmonyLib;
using MelonLoader;
using System;
using System.Reflection;

namespace DDSS_UnlimitedFramerate
{
    internal class MelonMain : MelonMod
    {
        internal static MelonLogger.Instance _logger;

        public override void OnInitializeMelon()
        {
            // Static Cache Logger
            _logger = LoggerInstance;

            // Apply Patches
            ApplyPatches();

            // Log Success
            _logger.Msg("Initialized!");
        }

        private void ApplyPatches()
        {
            Assembly melonAssembly = typeof(MelonMain).Assembly;
            foreach (Type type in melonAssembly.GetValidTypes())
            {
                // Check Type for any Harmony Attribute
                if (type.GetCustomAttribute<HarmonyPatch>() == null)
                    continue;

                // Apply
                try
                {
                    if (MelonDebug.IsEnabled())
                        LoggerInstance.Msg($"Applying {type.Name}");

                    HarmonyInstance.PatchAll(type);
                }
                catch (Exception e)
                {
                    LoggerInstance.Error($"Exception while attempting to apply {type.Name}: {e}");
                }
            }
        }
    }   
}
