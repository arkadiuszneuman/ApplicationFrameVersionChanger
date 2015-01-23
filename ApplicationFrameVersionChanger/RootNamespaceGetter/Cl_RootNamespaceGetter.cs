using System.Linq;
using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.RootNamespaceGetter
{
    public class Cl_RootNamespaceGetter : I_RootNamespaceGetter
    {
        public XElement GetRootNamespace(XDocument vrpDocument)
        {
            return vrpDocument.Elements().First().Elements().First(el => el.Name.LocalName == "PropertyGroup").Elements().Single(el => el.Name.LocalName == "RootNamespace");
        }
    }
}