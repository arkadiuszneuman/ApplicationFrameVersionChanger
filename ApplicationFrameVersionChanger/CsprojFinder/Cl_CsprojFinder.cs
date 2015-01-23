using System.Collections.Generic;
using System.IO;

namespace ApplicationFrameVersionChanger.CsprojFinder
{
    public class Cl_CsprojFinder : I_CsprojFinder
    {
        public IEnumerable<string> FindCsProjs(string vrpSlnPath)
        {
            var vrlDir = Path.GetDirectoryName(vrpSlnPath);
            return Directory.GetFiles(vrlDir, "*.csproj", SearchOption.AllDirectories);
        }
    }
}