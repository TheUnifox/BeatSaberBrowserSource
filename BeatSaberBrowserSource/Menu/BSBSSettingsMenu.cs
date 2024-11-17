using BeatSaberMarkupLanguage.Attributes;
using HMUI;
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
            exampleImage.color = Color.white;
            exampleText.text = "Hello World!";
        }
    }
}