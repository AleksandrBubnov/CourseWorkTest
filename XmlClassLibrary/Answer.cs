using System.Xml.Serialization;
using System.Collections.Generic;


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

    [XmlRoot(ElementName = "Question")]
    public class Question
    {
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Difficulty")]
        public string Difficulty { get; set; }
        [XmlElement(ElementName = "Answer")]
        public List<Answer> Answer { get; set; }
    }

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
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }
}
