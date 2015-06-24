using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using ApplicationFrameVersionChanger.AssemblyElementGetter;
using ApplicationFrameVersionChanger.CsprojFinder;
using ApplicationFrameVersionChanger.CurrentVersionFinder;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.RootNamespaceGetter;
using ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoChanger;
using ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoPathGetter;
using ApplicationFrameVersionChanger.VersionChanger.DocumentationElementGetter;
using ApplicationFrameVersionChanger.VersionChanger.TFSFileCheckouter;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace ApplicationFrameVersionChanger.VersionChanger
{
    public class Cl_VersionChanger
    {
        private readonly I_CsprojFinder vrcCsprojFinder;
        private readonly I_AssemblyElementGetter vrcAssemblyElementGetter;
        private readonly I_RootNamespaceGetter vrcRootNamespaceGetter;
        private readonly I_AssemblyInfoChanger vrcAssemblyInfoChanger;
        private readonly I_DocumentationFileElementGetter vrcDocumentationFileElementGetter;
        private readonly I_CurrentVersionFinder vrcCurrentVersionFinder;

        private readonly I_TFSFileCheckout vrcTFSFileCheckout;


        public Cl_VersionChanger(I_CsprojFinder vrpCsprojFinder, I_AssemblyElementGetter vrpAssemblyElementGetter,
            I_RootNamespaceGetter vrpRootNamespaceGetter, I_TFSFileCheckout vrpTFSFileCheckout, I_AssemblyInfoChanger vrpAssemblyInfoChanger, 
            I_DocumentationFileElementGetter vrpDocumentationFileElementGetter, I_CurrentVersionFinder vrpCurrentVersionFinder)
        {
            vrcCsprojFinder = vrpCsprojFinder;
            vrcAssemblyElementGetter = vrpAssemblyElementGetter;
            vrcRootNamespaceGetter = vrpRootNamespaceGetter;
            vrcTFSFileCheckout = vrpTFSFileCheckout;
            vrcAssemblyInfoChanger = vrpAssemblyInfoChanger;
            vrcDocumentationFileElementGetter = vrpDocumentationFileElementGetter;
            vrcCurrentVersionFinder = vrpCurrentVersionFinder;
        }

        public void ChangeVersion(string vrpSlnPath, string vrpNewVersion, bool vrpCheckoutFiles)
        {
            foreach (string vrlCsproj in vrcCsprojFinder.FindCsProjs(vrpSlnPath).Where(p => !GetDisabledProjects().Contains(Path.GetFileNameWithoutExtension(p))))
            {
                XDocument vrlDocument = XDocument.Load(vrlCsproj);
                XElement vrlAssemblyElement = vrcAssemblyElementGetter.GetAssemblyElement(vrlDocument);
                XElement vrlRootNamespace = vrcRootNamespaceGetter.GetRootNamespace(vrlDocument);

                string vrlOldVersion = vrcCurrentVersionFinder.GetCurrentVersionFromCsproj(vrlCsproj);

                if (vrpCheckoutFiles)
                {
                    vrcTFSFileCheckout.CheckoutFile(vrlCsproj);
                }

                foreach (XElement vrlDocumentationElement in vrcDocumentationFileElementGetter.GetDocumentationElements(vrlDocument))
                {
                    vrlDocumentationElement.Value = vrlDocumentationElement.Value.Replace(vrlOldVersion.Replace(".*", ""), vrpNewVersion.Replace(".*", ""));
                }

                vrcAssemblyInfoChanger.ChangeAssemblyInfo(vrlCsproj, vrlOldVersion, vrpNewVersion, vrpCheckoutFiles);

                vrlAssemblyElement.SetValue(vrlRootNamespace.Value + '.' +  vrpNewVersion.Replace(".*", ""));
                vrlDocument.Save(vrlCsproj);
            }
        }

        private IEnumerable<string> GetDisabledProjects()
        {
            yield return "AppFrameExamples";
            yield return "AppFrameExamplesCommon";
            yield return "AppFrameInHubTest";
            yield return "AppFrameTest";
            yield return "inHub";
            yield return "inHubMain";
            yield return "inHubNavireo";
            yield return "Main";
            yield return "MainNav";
        }
    }
}