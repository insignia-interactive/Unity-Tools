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

            #region Fundementals

        [MenuItem("Tools/Setup/Packages/Fundementals/New Input System")]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");

        [MenuItem("Tools/Setup/Packages/Fundementals/Visual Scripting")]
        static void AddVisualScripting() => Packages.InstallUnityPackage("visualscripting");

            #endregion

            #region Camera

        [MenuItem("Tools/Setup/Packages/Camera/Cinemachine")]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");

        [MenuItem("Tools/Setup/Packages/Camera/Post Processing")]
        static void AddPostProcessing() => Packages.InstallUnityPackage("postprocessing");

            #endregion

            #region Render Pipeline

        [MenuItem("Tools/Setup/Packages/Render Pipeline/Universal Render Pipeline")]
        static void AddURP() => Packages.InstallUnityPackage("render-pipelines.universal");

        [MenuItem("Tools/Setup/Packages/Render Pipeline/High Definition Pipeline")]
        static void AddHDRP() => Packages.InstallUnityPackage("render-pipelines.high-definition");

            #endregion

            #region Other

                #region Custom

        [MenuItem("Tools/Setup/Packages/Other/Custom/PerspectiveAPI")]
        static void AddPerspectiveAPI() => Packages.InstallUnityPackageFromURL("https://github.com/DanDHenshaw/Perspective-API-for-Unity.git");

                #endregion

            #endregion

        #endregion
    }
}
