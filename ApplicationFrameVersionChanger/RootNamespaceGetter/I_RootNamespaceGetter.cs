using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.RootNamespaceGetter
{
    public interface I_RootNamespaceGetter
    {
        XElement GetRootNamespace(XDocument vrpDocument);
    }
}