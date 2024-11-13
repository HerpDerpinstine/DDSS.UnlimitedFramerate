using Il2Cpp;

namespace DDSS_UnlimitedFramerate.Utils
{
    internal static class Extensions
    {
        public static SettingAlternative FindAlternativeByKey(this Setting setting, string key)
        {
            if (setting.alternatives == null)
                return null;
            foreach (var alternative in setting.alternatives)
                if (alternative.key == key)
                    return alternative;
            return null;
        }
    }
}
