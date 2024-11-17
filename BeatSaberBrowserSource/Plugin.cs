using BeatSaberBrowserSource.Configuration;
using UnityEngine;
using IPA;
using IPA.Config.Stores;
using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;
using IPA.Loader;

namespace BeatSaberBrowserSource
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static IPALogger Log { get; private set; }

        [Init]
        public Plugin(IPALogger logger, IPAConfig conf, PluginMetadata meta)
        {
            Log = logger;
            PluginConfig.Instance = conf.Generated<PluginConfig>();
            Log.Debug("BeatSaberBrowserSource initialized and config loaded");
        }


        [OnStart]
        public void OnApplicationStart()
        {
            Log.Debug("OnApplicationStart");
            new GameObject("BeatSaberBrowserSourceController").AddComponent<BeatSaberBrowserSourceController>();

        }

        [OnExit]
        public void OnApplicationQuit()
        {
            Log.Debug("OnApplicationQuit");

        }
    }
}
