using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(DDSS_UnlimitedFramerate.Properties.BuildInfo.Description)]
[assembly: AssemblyDescription(DDSS_UnlimitedFramerate.Properties.BuildInfo.Description)]
[assembly: AssemblyCompany(DDSS_UnlimitedFramerate.Properties.BuildInfo.Company)]
[assembly: AssemblyProduct(DDSS_UnlimitedFramerate.Properties.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + DDSS_UnlimitedFramerate.Properties.BuildInfo.Author)]
[assembly: AssemblyTrademark(DDSS_UnlimitedFramerate.Properties.BuildInfo.Company)]
[assembly: AssemblyVersion(DDSS_UnlimitedFramerate.Properties.BuildInfo.Version)]
[assembly: AssemblyFileVersion(DDSS_UnlimitedFramerate.Properties.BuildInfo.Version)]
[assembly: MelonInfo(typeof(DDSS_UnlimitedFramerate.MelonMain), 
    DDSS_UnlimitedFramerate.Properties.BuildInfo.Name, 
    DDSS_UnlimitedFramerate.Properties.BuildInfo.Version,
    DDSS_UnlimitedFramerate.Properties.BuildInfo.Author,
    DDSS_UnlimitedFramerate.Properties.BuildInfo.DownloadLink)]
[assembly: MelonGame("StripedPandaStudios", "DDSS")]
[assembly: VerifyLoaderVersion("0.6.5", true)]
[assembly: HarmonyDontPatchAll]