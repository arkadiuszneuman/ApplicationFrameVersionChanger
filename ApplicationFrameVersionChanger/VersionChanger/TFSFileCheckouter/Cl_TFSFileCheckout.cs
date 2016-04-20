using System;
//using Microsoft.TeamFoundation.Client;
//using Microsoft.TeamFoundation.VersionControl.Client;

namespace ApplicationFrameVersionChanger.VersionChanger.TFSFileCheckouter
{
    public class Cl_TFSFileCheckout : I_TFSFileCheckout
    {
        private const string vrsServerName = "http://192.168.255.52:8080/tfs/";
        private readonly string vrcWorkspace;

        public Cl_TFSFileCheckout(string vrpWorkspace)
        {
            vrcWorkspace = vrpWorkspace;
        }

        public void CheckoutFile(string vrpFile)
        {
            //var server = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(vrsServerName));
            //var versionControl = (VersionControlServer)server.GetService(typeof(VersionControlServer));
            //// open a workspace.
            //var workspace = versionControl.GetWorkspace(vrcWorkspace);

            //var result = workspace.PendEdit(vrpFile);
        }
    }
}