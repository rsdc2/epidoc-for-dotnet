namespace EpiDocAPI.DataClasses
{
    using EpiDocAPI.DataClasses.Interfaces;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.XPath;

    public class EpiDoc : IEpiDocElement
    {
        static XNamespace _teiNS = "http://www.tei-c.org/ns/1.0";
        static XNamespace _xincludeNS = "http://www.w3.org/2001/XInclude";
        XmlDocument _xmlDoc = new XmlDocument();
        readonly XmlNamespaceManager _nsmgr;

        public EpiDoc(XmlDocument xmlDoc)
        {
            _xmlDoc = xmlDoc;

            // Set up namespaces
            // See https://learn.microsoft.com/en-us/dotnet/standard/data/xml/xpath-queries-and-namespaces
            // for why the default namespace has to be mapped to a prefix
            _nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            _nsmgr.AddNamespace("tei", _teiNS.ToString());
            _nsmgr.AddNamespace("xi", _xincludeNS.ToString());
        }

        public static EpiDoc FromXmlStr(string xmlStr)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlStr);
            return new EpiDoc(xmlDoc);
        }

        public static EpiDoc FromFile(string path)
        {
            var xmlStr = File.ReadAllText(path);
            return FromXmlStr(xmlStr);
        }

        public string ISicIdFromXPath
        {
            get => Root?.SelectSingleNode("descendant::tei:idno[@type='filename']", _nsmgr)?.InnerText ?? "";
        }

        public string ISicIdFromLinq
        {
            //get => RootXElement.XPathSelectElement("descendant::tei:idno[@type='filename']", _nsmgr)?.Value ?? "";
            //get => (from element in RootXElement.Descendants(_teiNS + "idno")
            //        where (string?)element.Attribute("type") == "filename"
            //        select element).FirstOrDefault()?.Value ?? "";

            get => Element
                    .Descendants(_teiNS + "idno")
                    .Where(e => (string?)e.Attribute("type") == "filename")
                    .FirstOrDefault()?
                    .Value ?? "";
        }

        public XmlNode? Root
        {
            get => _xmlDoc.DocumentElement;
        }
        
        public XElement Element
        {
            get => XElement.Parse(_xmlDoc.OuterXml);
        }
    }
}
