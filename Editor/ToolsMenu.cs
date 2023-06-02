using UnityEngine;
using UnityEditor;

namespace Insignia
{
    public static class ToolsMenu
    {
        #region Default Folder Structure

        [MenuItem("Tools/Setup/Create Default Folders", priority = 1)]
        static void CreateDefaultFolders()
        {
            Debug.Log(Application.dataPath);

            string[] structure = new string[] { "Art/Materials", "Art/Models", "Art/Textures", "Audio/Music", "Audio/Sound", "Code/Scripts", "Code/Shaders", "Docs", "Level/Prefabs", "Level/Scenes", "Level/UI" };

            Folders.CreateDirectories("_Project", structure);
            AssetDatabase.Refresh();
        }

        #endregion

        #region Default Manifest

        [MenuItem("Tools/Setup/Load New Manifest", priority = 2)]
        static async void LoadNewManifest() => await Packages.ReplacePackageFromGist("4ba2be47500ddc0626eb2bd67b9576a2");

        #endregion

        #region Packages

            #region Fundementals

        [MenuItem("Tools/Setup/Packages/Fundementals/New Input System", priority = 100)]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");

        [MenuItem("Tools/Setup/Packages/Fundementals/Visual Scripting", priority = 101)]
        static void AddVisualScripting() => Packages.InstallUnityPackage("visualscripting");

            #endregion

            #region Camera

        [MenuItem("Tools/Setup/Packages/Camera/Cinemachine", priority = 200)]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");

        [MenuItem("Tools/Setup/Packages/Camera/Post Processing", priority = 201)]
        static void AddPostProcessing() => Packages.InstallUnityPackage("postprocessing");

            #endregion

            #region Render Pipeline

        [MenuItem("Tools/Setup/Packages/Render Pipeline/Universal Render Pipeline", priority = 300)]
        static void AddURP() => Packages.InstallUnityPackage("render-pipelines.universal");

        [MenuItem("Tools/Setup/Packages/Render Pipeline/High Definition Pipeline", priority = 301)]
        static void AddHDRP() => Packages.InstallUnityPackage("render-pipelines.high-definition");

            #endregion

            #region Other

                #region Custom

        [MenuItem("Tools/Setup/Packages/Other/Custom/PerspectiveAPI", priority = 1000)]
        static void AddPerspectiveAPI() => Packages.InstallUnityPackageFromURL("https://github.com/DanDHenshaw/Perspective-API-for-Unity.git");

                #endregion

            #endregion

        #endregion
    }
}
