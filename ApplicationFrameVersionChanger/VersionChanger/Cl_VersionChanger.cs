using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using ApplicationFrameVersionChanger.AssemblyElementGetter;
using ApplicationFrameVersionChanger.CsprojFinder;
using ApplicationFrameVersionChanger.FileTextLoader;
using ApplicationFrameVersionChanger.RootNamespaceGetter;
using ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoChanger;
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

        private readonly I_TFSFileCheckout vrcTFSFileCheckout;


        public Cl_VersionChanger(I_CsprojFinder vrpCsprojFinder, I_AssemblyElementGetter vrpAssemblyElementGetter, 
            I_RootNamespaceGetter vrpRootNamespaceGetter, I_TFSFileCheckout vrpTFSFileCheckout, I_AssemblyInfoChanger vrpAssemblyInfoChanger)
        {
            vrcCsprojFinder = vrpCsprojFinder;
            vrcAssemblyElementGetter = vrpAssemblyElementGetter;
            vrcRootNamespaceGetter = vrpRootNamespaceGetter;
            vrcTFSFileCheckout = vrpTFSFileCheckout;
            vrcAssemblyInfoChanger = vrpAssemblyInfoChanger;
        }

        public void ChangeVersion(string vrpSlnPath, string vrpNewVersion, bool vrpCheckoutFiles)
        {
            foreach (string vrlCsproj in vrcCsprojFinder.FindCsProjs(vrpSlnPath).Where(p => !GetDisabledProjects().Contains(Path.GetFileNameWithoutExtension(p))))
            {
                if (vrlCsproj.Contains("inSolutions.Utilities"))
                {
                    XDocument vrlDocument = XDocument.Load(vrlCsproj);
                    XElement vrlAssemblyElement = vrcAssemblyElementGetter.GetAssemblyElement(vrlDocument);
                    XElement vrlRootNamespace = vrcRootNamespaceGetter.GetRootNamespace(vrlDocument);

                    if (vrpCheckoutFiles)
                    {
                        vrcTFSFileCheckout.CheckoutFile(vrlCsproj);
                    }

                    vrcAssemblyInfoChanger.ChangeAssemblyInfo(vrlCsproj, vrlAssemblyElement.Value.Replace(vrlRootNamespace.Value + '.', ""), vrpNewVersion, vrpCheckoutFiles);

                    vrlAssemblyElement.SetValue(vrlRootNamespace.Value + '.' + vrpNewVersion);
                    vrlDocument.Save(vrlCsproj);
                }
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