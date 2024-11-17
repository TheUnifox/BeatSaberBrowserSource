using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;
using UnityEngine;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BeatSaberBrowserSource
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
            public virtual bool enablePanel { get; set; }
        }

        public static PluginConfig Instance { get; set; }

        [UseConverter(typeof(ListConverter<PanelInfo>))]
        public virtual List<PanelInfo> PanelsConfig { get; set; }
            = new List<PanelInfo>();

        /*
        /// <summary>
        /// This is called whenever BSIPA reads the config from disk (including when file changes are detected).
        /// </summary>
        public virtual void OnReload() { }

        /// <summary>
        /// Call this to force BSIPA to update the config file. This is also called by BSIPA if it detects the file was modified.
        /// </summary>
        public virtual void Changed() { }
        
        /// <summary>
        /// Call this to have BSIPA copy the values from <paramref name="other"/> into this config.
        /// </summary>
        public virtual void CopyFrom(PluginConfig other) { }
        */
    }
}

