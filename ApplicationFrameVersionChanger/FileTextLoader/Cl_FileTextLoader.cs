using System.IO;

namespace ApplicationFrameVersionChanger.FileTextLoader
{
    public class Cl_FileTextLoader : I_FileTextLoader
    {
        public string GetTextFromFile(string vrpFilePath)
        {
            return File.ReadAllText(vrpFilePath);
        }
    }
}