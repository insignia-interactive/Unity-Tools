using UnityEngine;
using UnityEditor;

namespace Insignia
{
    public static class ToolsMenu
    {
        #region MyRegion

        [MenuItem("Tools/Setup/Create Default Folders")]
        static void CreateDefaultFolders()
        {
            Debug.Log(Application.dataPath);

            string[] structure = new string[] { "Art/Materials", "Art/Models", "Art/Textures", "Audio/Music", "Audio/Sound", "Code/Scripts", "Code/Shaders", "Docs", "Level/Prefabs", "Level/Scenes", "Level/UI" };

            Folders.CreateDirectories("_Project", structure);
            AssetDatabase.Refresh();
        }

        #endregion

        #region Default Manifest

        [MenuItem("Tools/Setup/Load New Manifest")]
        static async void LoadNewManifest() => await Packages.ReplacePackageFromGist("4ba2be47500ddc0626eb2bd67b9576a2");

        #endregion

        #region Packages

        [MenuItem("Tools/Setup/Packages/Other/PerspectiveAPI")]
        static void AddPerspectiveAPI() => Packages.InstallUnityPackageFromURL("https://github.com/DanDHenshaw/Perspective-API-for-Unity.git");

        [MenuItem("Tools/Setup/Packages/Other/New Input System")]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");

        [MenuItem("Tools/Setup/Packages/Camera/Cinemachine")]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");

        [MenuItem("Tools/Setup/Packages/Visual/Universal Render Pipeline")]
        static void AddURP() => Packages.InstallUnityPackage("render-pipelines.universal");

        [MenuItem("Tools/Setup/Packages/Visual/Post Processing")]
        static void AddPostProcessing() => Packages.InstallUnityPackage("postprocessing");

        #endregion
    }
}
