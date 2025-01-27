namespace EpiDocAPI.DataClasses.Interfaces
{
    using System.Xml.Linq;

    public interface IEpiDocElement
    {
        XElement Element { get; }   
    }
}
