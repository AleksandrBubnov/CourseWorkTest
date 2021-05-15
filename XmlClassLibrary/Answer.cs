using System.Xml.Serialization;

namespace XmlClassLibrary
{
    [XmlRoot(ElementName = "Answer")]
    public class Answer
    {
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "IsRight")]
        public string IsRight { get; set; }
    }
}
