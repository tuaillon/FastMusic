using System.IO;

namespace FastMusic
{
    internal class DataHandler
    {
        private readonly string m_jsonPath = Path.Combine(PathManager.GetDefaultPath, "data.json");
        public static void registerSong(string id,
                                   string title,
                                   string artist,
                                   string fileName,
                                   string imageName)
        {

        }
    }
}
