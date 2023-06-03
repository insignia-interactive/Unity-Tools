using System.IO;
using UnityEngine;
using UnityEditor;

namespace Insignia
{
    public static class Folders
    {
        public static void CreateDirectories(string root, params string[] dir)
        {
            var fullpath = Path.Combine(Application.dataPath, root);
            foreach (var newDir in dir)
            {
                Directory.CreateDirectory(Path.Combine(fullpath, newDir));
            }
        }

        public static void MoveScenes(string oldSceneFolder, string newSceneFolder)
        {
            oldSceneFolder = Path.Combine(Application.dataPath, oldSceneFolder);
            newSceneFolder = Path.Combine(Application.dataPath, newSceneFolder);

            FileUtil.MoveFileOrDirectory(oldSceneFolder, newSceneFolder);
            FileUtil.DeleteFileOrDirectory($"{oldSceneFolder}.meta");
            FileUtil.DeleteFileOrDirectory(oldSceneFolder);
        }
    }
}