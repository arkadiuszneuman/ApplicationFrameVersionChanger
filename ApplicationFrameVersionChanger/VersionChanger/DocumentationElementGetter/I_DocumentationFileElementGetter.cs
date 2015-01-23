using System.Collections.Generic;
using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.VersionChanger.DocumentationElementGetter
{
    public interface I_DocumentationFileElementGetter
    {
        IEnumerable<XElement> GetDocumentationElements(XDocument vrpDocument);
    }
}