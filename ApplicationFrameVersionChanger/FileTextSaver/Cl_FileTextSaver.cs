using System.IO;

namespace ApplicationFrameVersionChanger.FileTextSaver
{
    public class Cl_FileTextSaver : I_FileTextSaver
    {
        public void SaveText(string vrpFilePath, string vrpTextToSave)
        {
            string vrlDirectoryName = Path.GetDirectoryName(vrpFilePath);
            if (!Directory.Exists(vrlDirectoryName))
            {
                Directory.CreateDirectory(vrlDirectoryName);
            }

            if (File.Exists(vrpFilePath))
            {
                File.SetAttributes(vrpFilePath, FileAttributes.Normal);
                File.Delete(vrpFilePath);
            }

            File.WriteAllText(vrpFilePath, vrpTextToSave);
        }
    }
}