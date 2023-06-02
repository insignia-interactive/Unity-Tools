using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Insignia
{
    public static class Packages
    {
        public static async Task ReplacePackageFromGist(string id, string user = "Insignia-collab")
        {
            var url = GetGistUrl(id, user);
            var contents = await GetContents(url);
            ReplacePackageFile(contents);
        }

        private static string GetGistUrl(string id, string user) =>
            $"https://gist.githubusercontent.com/{user}/{id}/raw";

        private static async Task<string> GetContents(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        private static void ReplacePackageFile(string contents)
        {
            var existing = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            File.WriteAllText(existing, contents);
            UnityEditor.PackageManager.Client.Resolve();
        }

        #region Manual Unity Packages

        public static void InstallUnityPackage(string packageName) =>
            UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");

        public static void InstallUnityPackageFromURL(string url) =>
            UnityEditor.PackageManager.Client.Add(url);

        public static async Task InstallPackageFromGist(string id, string user, string gistName)
        {
            var url = GetGistUrl(id, user);
            var contents = await GetContents(url);
            InstallScript(contents, gistName);
        }

        #endregion

        #region Gist Script

        private static void InstallScript(string contents, string gistName)
        {
            var folder = Path.Combine(Application.dataPath, "Editor");
            Directory.CreateDirectory(folder);

            var script = Path.Combine(folder, $"{gistName}.cs");
            File.WriteAllText(script, contents);
            AssetDatabase.Refresh();
        }

        #endregion
    }
}