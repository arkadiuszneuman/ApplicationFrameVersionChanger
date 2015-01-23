using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.AssemblyElementGetter
{
    public interface I_AssemblyElementGetter
    {
        XElement GetAssemblyElement(XDocument vrpDocument);
    }
}