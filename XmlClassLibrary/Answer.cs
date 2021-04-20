using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

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
        public Question()
        {
            Answer = new List<Answer>();
        }
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
        public Test()
        {
            Question = new List<Question>();
        }
    }
    public class Serializer
    {
        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T)); 
            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
    public class AnswerEqualityComparer : IEqualityComparer<Answer>
    {
        //public bool Equals(Data x, Data y)
        //{
        //    return true;
        //}
        //public int GetHashCode(Data obj)
        //{
        //    return obj.nPart.GetHashCode();
        //}
        public bool Equals(Answer x, Answer y)
        {
            if (x.IsRight.Equals(y.IsRight)) return true;
            return false;
        }

        public int GetHashCode(Answer obj)
        {
            return obj.IsRight.GetHashCode();
        }
    }
}
