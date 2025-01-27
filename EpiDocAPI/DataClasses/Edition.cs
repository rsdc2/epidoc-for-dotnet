namespace EpiDocAPI.DataClasses
{
    using EpiDocAPI.DataClasses.Interfaces;
    using System.Xml.Linq;

    public class Edition : IEpiDocElement
    {
        XElement _element;
        public XElement Element { get => _element; }

        public Edition(XElement editionElement)
        { 
            _element = editionElement;
        }


        
    }
}
