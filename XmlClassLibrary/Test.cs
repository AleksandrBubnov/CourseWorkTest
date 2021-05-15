using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlClassLibrary
{
    [XmlRoot(ElementName = "Test")]
    public class Test
    {
        [XmlElement(ElementName = "Author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "TestName")]
        public string TestName { get; set; }
        [XmlElement(ElementName = "Qty_questions")]
        public string Qty_questions { get; set; }
        [XmlElement(ElementName = "Question")]
        public List<Question> Question { get; set; }
        //[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        //public string Xsi { get; set; }
        //[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        //public string Xsd { get; set; }
        public Test()
        {
            Question = new List<Question>();
        }
    }
}
