using System.Linq;
using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.AssemblyElementGetter
{
    public class Cl_AssemblyElementGetter : I_AssemblyElementGetter
    {
        public XElement GetAssemblyElement(XDocument vrpDocument)
        {
            return vrpDocument.Elements().First().Elements().First(el => el.Name.LocalName == "PropertyGroup").Elements().Single(el => el.Name.LocalName == "AssemblyName");
        }
    }
}