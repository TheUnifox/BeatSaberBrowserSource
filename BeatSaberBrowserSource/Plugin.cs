﻿using IPA;
using IPA.Config.Stores;
using IPA.Loader;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;
using System.Reflection;
using Newtonsoft.Json;

namespace BeatSaberBrowserSource
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    internal class Plugin
    {
        internal static IPALogger Log { get; private set; }

        // Methods with [Init] are called when the plugin is first loaded by IPA.
        // All the parameters are provided by IPA and are optional.
        // The constructor is called before any method with [Init]. Only use [Init] with one constructor.
        
        [Init]
        public Plugin(IPALogger ipaLogger, IPAConfig ipaConfig, PluginMetadata pluginMetadata)
        {
            Log = ipaLogger;
            
            // Creates an instance of PluginConfig used by IPA to load and store config values
            PluginConfig.Instance = ipaConfig.Generated<PluginConfig>();

            Log.Warn(JsonConvert.SerializeObject(pluginMetadata.Assembly.GetManifestResourceNames()));
            Log.Info($"{pluginMetadata.Name} {pluginMetadata.HVersion} initialized.");
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