using System.IO;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.FileTextSaver;
using ApplicationFrameVersionChanger.VersionChanger.TFSFileCheckouter;

namespace ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoChanger
{
    public class Cl_AssemblyInfoChanger : I_AssemblyInfoChanger
    {
        private readonly I_TFSFileCheckout vrcTFSFileCheckout;
        private readonly I_FileTextLoader vrcFileTextLoader;
        private readonly I_FileTextSaver vrcFileTextSaver;

        public Cl_AssemblyInfoChanger(I_TFSFileCheckout vrpTFSFileCheckout, I_FileTextLoader vrpFileTextLoader, I_FileTextSaver vrpFileTextSaver)
        {
            vrcTFSFileCheckout = vrpTFSFileCheckout;
            vrcFileTextLoader = vrpFileTextLoader;
            vrcFileTextSaver = vrpFileTextSaver;
        }


        public void ChangeAssemblyInfo(string vrpCsprojFile, string vrpOldVersion, string vrpNewVersion, bool vrpCheckoutFile)
        {
            string vrlDirectory = Path.GetDirectoryName(vrpCsprojFile);
            string vrlAssemblyInfoPath = Path.Combine(vrlDirectory, Path.Combine("Properties", "AssemblyInfo.cs"));

            if (vrpCheckoutFile)
            {
                vrcTFSFileCheckout.CheckoutFile(vrlAssemblyInfoPath);
            }

            string vrlTextFromFile = vrcFileTextLoader.GetTextFromFile(vrlAssemblyInfoPath);
            vrlTextFromFile = vrlTextFromFile.Replace(vrpOldVersion, vrpNewVersion);
            vrcFileTextSaver.SaveText(vrlAssemblyInfoPath, vrlTextFromFile);
        }
    }
}