using System.IO;
using UnityEngine;
using UnityEditor;

using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace Insignia
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Debug.Log(dataPath);

            string[] structure = new string[] { "Art/Materials", "Art/Models", "Art/Textures", "Audio/Music", "Audio/Sound", "Code/Scripts", "Code/Shaders", "Docs", "Level/Prefabs", "Level/Scenes", "Level/UI" };

            Dir("_Project", structure);
            Refresh();
        }

        public static void Dir(string root, params string[] dir)
        {
            var fullpath = Combine(dataPath, root);
            foreach (var newDir in dir)
            {
                CreateDirectory(Combine(fullpath, newDir));
            }
        }
    }
}
