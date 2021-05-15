using System;
using System.Collections.Generic;

namespace DALServerDB.Infrastructure
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public User()
        {
            Groups = new List<Group>();
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    [Serializable]
    public class UserAnswear
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Answear Answear { get; set; }
    }
    [Serializable]
    public class Group
    {
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public Group()
        {
            Users = new List<User>();
            Tests = new List<Test>();
        }
    }
    [Serializable]
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public TimeSpan Time { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public Test()
        {
            Questions = new List<Question>();
            Groups = new List<Group>();
        }
        public override string ToString()
        {
            return $"{Title}";
        }
    }
    [Serializable]
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Difficulty { get; set; }
        public Test Test { get; set; }
        public virtual ICollection<Answear> Answears { get; set; }
        public Question()
        {
            Answears = new List<Answear>();
        }
    }
    [Serializable]
    public class Answear
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsRight { get; set; }
        public Question Question { get; set; }
    }
    [Serializable]
    public class Result
    {
        public int Id { get; set; }
        public int QtyOfRightAnswers { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Test Test { get; set; }
    }
}
