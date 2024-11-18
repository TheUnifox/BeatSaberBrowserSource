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

            public PanelInfo(string name, Vector3 pos, Vector3 rot, Vector2 size, string url, bool enablePanel)
            {
                this.name = name;
                this.pos = pos;
                this.rot = rot;
                this.size = size;
                this.url = url;
                this.enablePanel = enablePanel;
            }

            public PanelInfo()
            {
                this.name = "New Panel";
                this.pos = new Vector3();
                this.rot = new Vector3();
                this.size = new Vector2();
                this.url = "https://obsproject.com/browser-source"; // OBS default browser source url lol
                this.enablePanel = true;
            }
        }

        public static PluginConfig Instance { get; set; }

        [UseConverter(typeof(ListConverter<PanelInfo>))]
        public virtual List<PanelInfo> PanelsConfig { get; set; }
            = new List<PanelInfo>();

        [UseConverter(typeof(ListConverter<string>))]
        public virtual List<string> PanelNames { get; set; } = new List<string>();

        /// <summary>
        /// This is called whenever BSIPA reads the config from disk (including when file changes are detected).
        /// </summary>
        public virtual void OnReload() 
        {
            foreach (PanelInfo panel in PanelsConfig)
            {
                PanelNames.Add(panel.name);
            }
        }

        /*
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

