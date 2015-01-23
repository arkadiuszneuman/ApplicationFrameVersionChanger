using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ApplicationFrameVersionChanger.VersionChanger.DocumentationElementGetter
{
    public class Cl_DocumentationFileElementGetter : I_DocumentationFileElementGetter
    {
        public IEnumerable<XElement> GetDocumentationElements(XDocument vrpDocument)
        {
            return vrpDocument.Elements().First().Elements().Where(el => el.Name.LocalName == "PropertyGroup").SelectMany(el => el.Elements()).Where(el => el.Name.LocalName == "DocumentationFile");
        }
    }
}