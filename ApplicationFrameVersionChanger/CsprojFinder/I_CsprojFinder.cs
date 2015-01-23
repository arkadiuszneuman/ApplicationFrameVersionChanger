using System.Collections.Generic;

namespace ApplicationFrameVersionChanger.CsprojFinder
{
    public interface I_CsprojFinder
    {
        IEnumerable<string> FindCsProjs(string vrpSlnPath);
    }
}