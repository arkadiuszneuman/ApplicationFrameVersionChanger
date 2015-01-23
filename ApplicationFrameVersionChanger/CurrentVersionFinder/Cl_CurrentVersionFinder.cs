using System.IO;
using System.Linq;
using System.Xml.Linq;
using ApplicationFrameVersionChanger.AssemblyElementGetter;
using ApplicationFrameVersionChanger.CsprojFinder;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.RootNamespaceGetter;

namespace ApplicationFrameVersionChanger.CurrentVersionFinder
{
    public class Cl_CurrentVersionFinder
    {
        private readonly I_CsprojFinder vrcCsprojFinder;
        private readonly I_FileTextLoader vrcFileTextLoader;
        private readonly I_AssemblyElementGetter vrcAssemblyElementGetter;
        private readonly I_RootNamespaceGetter vrcRootNamespaceGetter;

        public Cl_CurrentVersionFinder(I_CsprojFinder vrpCsprojFinder, I_FileTextLoader vrpFileTextLoader, I_AssemblyElementGetter vrpAssemblyElementGetter, I_RootNamespaceGetter vrpRootNamespaceGetter)
        {
            vrcCsprojFinder = vrpCsprojFinder;
            vrcFileTextLoader = vrpFileTextLoader;
            vrcAssemblyElementGetter = vrpAssemblyElementGetter;
            vrcRootNamespaceGetter = vrpRootNamespaceGetter;
        }

        public string GetCurrentVersion(string vrpSlnFile)
        {
            string vrlCsProjFile = vrcCsprojFinder.FindCsProjs(vrpSlnFile).Single(f => Path.GetFileNameWithoutExtension(f).Contains("inSolutions.Utilities"));
            string vrlTextFromFile = vrcFileTextLoader.GetTextFromFile(vrlCsProjFile);

            XDocument vrlDocument = XDocument.Load(new StringReader(vrlTextFromFile));
            XElement vrlAssemblyElement = vrcAssemblyElementGetter.GetAssemblyElement(vrlDocument);
            return vrlAssemblyElement.Value.Replace(vrcRootNamespaceGetter.GetRootNamespace(vrlDocument).Value + '.', "");
        }
    }
}