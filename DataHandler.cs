using System.IO;

namespace FastMusic
{
    internal class DataHandler
    {
        private static readonly string m_jsonPath = Path.Combine(PathManager.GetDefaultPath, "data.json");

        public static void CreateDefaultDataFileIfNotExists()
        {
            if ( !File.Exists(m_jsonPath) )
                File.WriteAllText(m_jsonPath, "{}");
        }

        
        public static void registerSong(string id,
                                   string title,
                                   string artist,
                                   string fileName,
                                   string imageName)
        {

        }
    }
}
