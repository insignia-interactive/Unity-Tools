using System.IO;
using UnityEngine;

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
    }
}