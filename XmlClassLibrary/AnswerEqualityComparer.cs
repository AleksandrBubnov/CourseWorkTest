using System.Collections.Generic;

namespace XmlClassLibrary
{
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
