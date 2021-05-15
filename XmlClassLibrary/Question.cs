using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlClassLibrary
{
    [XmlRoot(ElementName = "Question")]
    public class Question
    {
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Difficulty")]
        public string Difficulty { get; set; }
        [XmlElement(ElementName = "Answer")]
        public List<Answer> Answer { get; set; }
        public Question()
        {
            Answer = new List<Answer>();
        }
    }
}
