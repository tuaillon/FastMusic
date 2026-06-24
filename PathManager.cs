using System;
using System.IO;

namespace FastMusic
{
    internal class PathManager
    {
        public static string GetDefaultPath
        {
            get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "fastMusic");
        }

        public static string GetDefaultThemePath
        {
            get => Path.Combine(GetDefaultPath, "themes");
        }

        public static void CreateDefaultIfNotExists()
        {
            string dir = Path.Combine(getDesktopPath(), "fastMusic");

            if ( !Directory.Exists(dir) )
                Directory.CreateDirectory(dir);

            string themeDir = Path.Combine(dir, "themes");

            if ( !Directory.Exists(themeDir) )
                Directory.CreateDirectory(themeDir);

            string songsDir = Path.Combine(dir, "songs");

            if ( !Directory.Exists(songsDir) )
                Directory.CreateDirectory(songsDir);
        }

        private static string getDesktopPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
    }
}
