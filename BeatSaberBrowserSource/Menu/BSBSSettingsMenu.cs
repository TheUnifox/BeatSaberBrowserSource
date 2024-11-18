using BeatSaberMarkupLanguage.Attributes;
using HMUI;
using Newtonsoft.Json;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace BeatSaberBrowserSource.Menu
{
    internal class BSBSSettingsMenu : MonoBehaviour
    {
        public const string MenuName = nameof(BeatSaberBrowserSource);
        public const string ResourcePath = nameof(BeatSaberBrowserSource) + ".Menu.BSML.example.bsml";

        // [UIComponent] will get a specified component from the BSML object with the matching id
        [UIComponent("example-image")]
        private readonly ImageView exampleImage = null!;

        [UIComponent("example-text")] 
        private readonly TextMeshProUGUI exampleText = null!;

        private List<PluginConfig.PanelInfo> panelList = PluginConfig.Instance.PanelsConfig;

        [UIValue("panel-list-contents")]
        private List<string> panelNames = PluginConfig.Instance.PanelNames;

        /// <summary>
        /// The #post-parse event is provided by BSML. This action is invoked after BSML has parsed this object and
        /// all [UIComponent] and [UIObject] members have been populated. Any initialization logic for the menu
        /// should be done in here, rather than in Unity's Awake or Start events.
        /// </summary>
        [UIAction("#post-parse")]
        private void PostParse()
        {
            Plugin.Log.Debug($"{name} parsed");
        }

        [UIAction("add-panel")]
        private void AddPanel()
        {
            exampleImage.color = Color.white;
            exampleText.text = "Hello World!";
            if (PluginConfig.Instance.PanelsConfig == null) { PluginConfig.Instance.PanelsConfig = new List<PluginConfig.PanelInfo>(); }
            if (PluginConfig.Instance.PanelNames == null) { PluginConfig.Instance.PanelNames = new List<string>(); }
            PluginConfig.Instance.PanelsConfig.Add(new PluginConfig.PanelInfo());
            PluginConfig.Instance.PanelNames.Add("New Panel");
            panelList = PluginConfig.Instance.PanelsConfig;
            panelNames = PluginConfig.Instance.PanelNames;
        }

        [UIAction("panel-item-click")]
        private void PanelItemClick(string name)
        {
            exampleText.text = name;
        }
    }
}