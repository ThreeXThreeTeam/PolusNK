using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI.PluginLoading;
using MiraAPI.Utilities;
using MiraAPI;
using Reactor;
using Reactor.Networking.Attributes;
using Reactor.Networking;
using Reactor.Utilities;

namespace PolusNK;

[BepInAutoPlugin("Polus.NK", "Polus.NK")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class POlusNKPlugin : BasePlugin, IMiraPlugin
{
    private Harmony Harmony { get; } = new(Id);
    public ConfigFile GetConfigFile()
    {
        return Config;
    }

    public string OptionsTitleText => "Polus.NK";

    public override void Load()
    {
        Harmony.PatchAll();

        ReactorCredits.Register("PolusNK", Version.Truncate(11, "") ?? Version, true, ReactorCredits.AlwaysShow);



        Config.Save();
    }
}