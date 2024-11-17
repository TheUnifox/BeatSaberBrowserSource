using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using HMUI;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using BeatSaberBrowserSource.Configuration;

namespace BeatSaberBrowserSource.Menu
{
    internal class BSBSSettingsMenu : MonoBehaviour
    {
        public const string MenuName = nameof(BeatSaberBrowserSource);
        public const string ResourcePath = nameof(BeatSaberBrowserSource) + ".Menu.BSML.menu.bsml";

        [UIComponent("panel-list")]
        private readonly List<PluginConfig.PanelInfo> panelList = null; //PluginConfig.Instance.PanelsConfig;

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

        [UIAction("example-action")]
        private void ExampleAction()
        {
            Plugin.Log.Debug("button pressed!");
        }
    }
}