using BeatSaberMarkupLanguage.Settings;
using UnityEngine;

namespace BeatSaberBrowserSource.Menu
{
    internal static class MenuManager
    {
        private static BSBSSettingsMenu SettingsMenuInstance { get; set; }

        /// <summary>
        /// Adds a custom menu in the Mod Settings section of the main menu.
        /// This should only be called when the main menu is active.
        /// </summary>
        public static void AddSettingsMenu()
        {
            if (SettingsMenuInstance == null)
            {
                SettingsMenuInstance = new GameObject(nameof(BSBSSettingsMenu)).AddComponent<BSBSSettingsMenu>();
                Object.DontDestroyOnLoad(SettingsMenuInstance.gameObject);
            }

            RemoveSettingsMenu();

            BSMLSettings.Instance.AddSettingsMenu(
                BSBSSettingsMenu.MenuName, BSBSSettingsMenu.ResourcePath, SettingsMenuInstance);
        }

        public static void RemoveSettingsMenu()
        {
            BSMLSettings.Instance.RemoveSettingsMenu(SettingsMenuInstance);
        }
    }
}