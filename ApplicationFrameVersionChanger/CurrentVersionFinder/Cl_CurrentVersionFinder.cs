using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using ApplicationFrameVersionChanger.CsprojFinder;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoPathGetter;

namespace ApplicationFrameVersionChanger.CurrentVersionFinder
{
    public class Cl_CurrentVersionFinder : I_CurrentVersionFinder
    {
        private readonly I_CsprojFinder vrcCsprojFinder;
        private readonly I_FileTextLoader vrcFileTextLoader;

        private readonly I_AssemblyInfoPathGetter vrcAssemblyInfoPathGetter;

        public Cl_CurrentVersionFinder(I_CsprojFinder vrpCsprojFinder, I_FileTextLoader vrpFileTextLoader, I_AssemblyInfoPathGetter vrpAssemblyInfoPathGetter)
        {
            vrcCsprojFinder = vrpCsprojFinder;
            vrcFileTextLoader = vrpFileTextLoader;
            vrcAssemblyInfoPathGetter = vrpAssemblyInfoPathGetter;
        }

        public string GetCurrentVersion(string vrpSlnFile)
        {
            string vrlCsProjFile = vrcCsprojFinder.FindCsProjs(vrpSlnFile).Single(f => Path.GetFileNameWithoutExtension(f).Contains("inSolutions.Utilities"));
            string vrlAssemblyInfoPath = vrcAssemblyInfoPathGetter.GetAssemblyInfoPath(vrlCsProjFile);
            string vrlAssemblyInfoText = vrcFileTextLoader.GetTextFromFile(vrlAssemblyInfoPath);
            foreach (string vrlLine in vrlAssemblyInfoText.Split(new [] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (vrlLine.Contains("AssemblyVersion") && !vrlLine.Contains("//"))
                {
                    return vrlLine.Replace("[assembly: AssemblyVersion(\"", "").Replace("\")]", "");
                }
            }

            return null;
        }
    }
}