using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BeatSaberBrowserSource.Configuration
{
    internal class PluginConfig
    {
        public class PanelInfo
        {
            public virtual string name { get; set; }
            public virtual Vector3 pos { get; set; }
            public virtual Vector3 rot { get; set; }
            public virtual Vector2 size { get; set; }
            public virtual string url { get; set; }
        }

        public static PluginConfig Instance { get; set; }

        /*
        // Must be 'virtual' if you want BSIPA to detect a value change and save the config automatically.
        [UseConverter(typeof(ListConverter<PanelInfo>))]
        public virtual List<PanelInfo> PanelsConfig { get; set; } 
            = new List<PanelInfo>(); 

        /*
        /// <summary>
        /// This is called whenever BSIPA reads the config from disk (including when file changes are detected).
        /// </summary>
        public virtual void OnReload()
        {
            // Do stuff after config is read from disk.
            // go through list of panels and set everything up
        }

        /// <summary>
        /// Call this to force BSIPA to update the config file. This is also called by BSIPA if it detects the file was modified.
        /// </summary>
        public virtual void Changed()
        {
            // Do stuff when the config is changed.
        }

        /// <summary>
        /// Call this to have BSIPA copy the values from <paramref name="other"/> into this config.
        /// </summary>
        public virtual void CopyFrom(BSBSConfig other)
        {
            // This instance's members populated from other
            PanelsConfig = other.PanelsConfig;
        }
        */
    }
}