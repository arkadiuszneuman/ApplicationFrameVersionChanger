using System.IO;

namespace ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoPathGetter
{
    public class Cl_AssemblyInfoPathGetter : I_AssemblyInfoPathGetter
    {
        public string GetAssemblyInfoPath(string vrpCsprojFile)
        {
            string vrlDirectory = Path.GetDirectoryName(vrpCsprojFile);
            string vrlAssemblyInfoPath = Path.Combine(vrlDirectory, Path.Combine("Properties", "AssemblyInfo.cs"));
            return vrlAssemblyInfoPath;
        }
    }
}