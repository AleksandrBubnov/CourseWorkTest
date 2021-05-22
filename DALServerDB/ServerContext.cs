using DALServerDB.Infrastructure;
using DALServerDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace DALServerDB
{
    public class ServerContext : DbContext
    {
        ///
        static ServerContext()
        {
            Database.SetInitializer<ServerContext>(new ServerContextInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new AnswearConfiguration());
            modelBuilder.Configurations.Add(new UserAnswearConfiguration());
            modelBuilder.Configurations.Add(new ResultConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        /// 
        public ServerContext(string conStr) : base(conStr) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answear> Answears { get; set; }
        public virtual DbSet<UserAnswear> UserAnswears { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }

    internal class ResultConfiguration : EntityTypeConfiguration<Result>
    {
        public ResultConfiguration()
        {
            ToTable("Result");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            Property(x => x.QtyOfRightAnswers).HasColumnType("int");
            Property(x => x.QtyOfRightAnswers).IsRequired();

            Property(x => x.Mark).HasColumnType("int");
            Property(x => x.Mark).IsRequired();

            Property(x => x.Date).HasColumnType("datetime");
            Property(x => x.Date).IsRequired();
        }
    }
    internal class UserAnswearConfiguration : EntityTypeConfiguration<UserAnswear>
    {
        public UserAnswearConfiguration()
        {
            ToTable("UserAnswear");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            Property(x => x.Date).IsRequired();
            Property(x => x.Date).HasColumnType("datetime");
        }
    }
    internal class AnswearConfiguration : EntityTypeConfiguration<Answear>
    {
        public AnswearConfiguration()
        {
            ToTable("Answear");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            //Property(x => x.Description).HasColumnName("Title");
            //Property(x => x.Description).HasColumnOrder(2);
            Property(x => x.Description).IsRequired();
            Property(x => x.Description).HasMaxLength(150);
            Property(x => x.Description).HasColumnType("nvarchar");

            //Property(x => x.IsRight).HasColumnType("bool");
            Property(x => x.IsRight).IsRequired();
        }
    }
    internal class QuestionConfiguration : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            ToTable("Question");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            //Property(x => x.Title).HasColumnName("Title");
            //Property(x => x.Title).HasColumnOrder(2);
            Property(x => x.Title).IsRequired();
            Property(x => x.Title).HasMaxLength(100);
            Property(x => x.Title).HasColumnType("nvarchar");

            Property(x => x.Difficulty).IsOptional();
            Property(x => x.Difficulty).HasColumnType("int");

            HasMany(x => x.Answears).WithRequired(y => y.Question).WillCascadeOnDelete();
        }
    }
    internal class TestConfiguration : EntityTypeConfiguration<Test>
    {
        public TestConfiguration()
        {
            ToTable("Test");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            //Property(x => x.Title).HasColumnName("Title");
            //Property(x => x.Title).HasColumnOrder(2);
            Property(x => x.Title).IsRequired();
            Property(x => x.Title).HasMaxLength(30);
            Property(x => x.Title).HasColumnType("nvarchar");

            Property(x => x.Author).IsOptional();
            Property(x => x.Author).HasMaxLength(30);
            Property(x => x.Author).HasColumnType("nvarchar");

            Property(x => x.Time).IsRequired();
            Property(x => x.Time).HasColumnType("time");

            HasMany(x => x.Groups).WithMany(y => y.Tests);
            HasMany(x => x.Questions).WithRequired(y => y.Test);
        }
    }
    internal class GroupConfiguration : EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            ToTable("Group");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            //Property(x => x.NameGroup).HasColumnName("NameGroup");
            //Property(x => x.NameGroup).HasColumnOrder(2);
            Property(x => x.NameGroup).IsRequired();
            Property(x => x.NameGroup).HasMaxLength(30);
            Property(x => x.NameGroup).HasColumnType("nvarchar");

            HasMany(x => x.Users).WithMany(y => y.Groups);
            HasMany(x => x.Tests).WithMany(y => y.Groups);
        }
    }
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnType("int");
            Property(x => x.Id).IsRequired();

            //Property(x => x.FirstName).HasColumnName("FirstName");
            //Property(x => x.FirstName).HasColumnOrder(2);
            Property(x => x.FirstName).IsRequired();
            Property(x => x.FirstName).HasMaxLength(30);
            Property(x => x.FirstName).HasColumnType("nvarchar");

            Property(x => x.LastName).IsRequired();
            Property(x => x.LastName).HasMaxLength(30);
            Property(x => x.LastName).HasColumnType("nvarchar");

            Property(x => x.Login).IsRequired();
            Property(x => x.Login).HasMaxLength(30);
            Property(x => x.Login).HasColumnType("nvarchar");

            Property(x => x.Password).IsRequired();
            Property(x => x.Password).HasMaxLength(256);
            Property(x => x.Password).HasColumnType("varchar");

            //Property(x => x.IsAdmin).HasColumnType("bool");
            Property(x => x.IsAdmin).IsRequired();

            HasMany(x => x.Groups).WithMany(y => y.Users);
        }
    }

    internal class ServerContextInitializer : CreateDatabaseIfNotExists<ServerContext>
    {
        /// CreateDatabaseIfNotExists<MyDbContext> - 
        /// Створити БД коли БД не існує
        /// DropCreateDatabaseIfModelChanges<MyDbContext> -  
        /// якщо зробили зміни в класі
        /// DropCreateDatabaseAlways<MyDbContext> - 
        /// кожен раз буде створюватися нова БД
        /// 
        protected override void Seed(ServerContext context)
        {
            User user1 = new User() { FirstName = "fname1", LastName = "lname1", IsAdmin = true, Login = "admin", Password = Crypter.SetCrypt("1") };
            User user2 = new User() { FirstName = "fname2", LastName = "lname2", IsAdmin = false, Login = "user1", Password = Crypter.SetCrypt("1") };
            User user3 = new User() { FirstName = "fname3", LastName = "lname3", IsAdmin = false, Login = "user2", Password = Crypter.SetCrypt("1") };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            Group group1 = new Group() { NameGroup = "group1" };
            Group group2 = new Group() { NameGroup = "group2" };
            Group group3 = new Group() { NameGroup = "group3" };

            context.Groups.Add(group1);
            context.Groups.Add(group2);
            context.Groups.Add(group3);

            Test test1 = new Test() { Author = "author1", Title = "title1", Time = TimeSpan.Zero };
            Test test2 = new Test() { Author = "author2", Title = "title2", Time = TimeSpan.Zero };
            Test test3 = new Test() { Author = "author3", Title = "title3", Time = TimeSpan.Zero };

            context.Tests.Add(test1);
            context.Tests.Add(test2);
            context.Tests.Add(test3);

            Question question1 = new Question() { Test = test1, Difficulty = 1, Title = "title1" };
            Question question2 = new Question() { Test = test2, Difficulty = 2, Title = "title2" };
            Question question3 = new Question() { Test = test3, Difficulty = 3, Title = "title3" };

            context.Questions.Add(question1);
            context.Questions.Add(question2);
            context.Questions.Add(question3);

            Answear answear1 = new Answear() { Description = "description1", IsRight = true, Question = question1 };
            Answear answear2 = new Answear() { Description = "description2", IsRight = true, Question = question2 };
            Answear answear3 = new Answear() { Description = "description3", IsRight = true, Question = question3 };

            context.Answears.Add(answear1);
            context.Answears.Add(answear2);
            context.Answears.Add(answear3);

            Result result1 = new Result() { Date = DateTime.Now, Mark = 1, QtyOfRightAnswers = 1, User = user1, Test = test1 };
            Result result2 = new Result() { Date = DateTime.Now, Mark = 2, QtyOfRightAnswers = 3, User = user2, Test = test2 };
            Result result3 = new Result() { Date = DateTime.Now, Mark = 4, QtyOfRightAnswers = 5, User = user3, Test = test3 };

            context.Results.Add(result1);
            context.Results.Add(result2);
            context.Results.Add(result3);

            UserAnswear userAnswear1 = new UserAnswear() { Date = DateTime.Now, User = user1, Answear = answear1 };
            UserAnswear userAnswear2 = new UserAnswear() { Date = DateTime.Now, User = user2, Answear = answear2 };
            UserAnswear userAnswear3 = new UserAnswear() { Date = DateTime.Now, User = user3, Answear = answear3 };

            context.UserAnswears.Add(userAnswear1);
            context.UserAnswears.Add(userAnswear2);
            context.UserAnswears.Add(userAnswear3);

            context.SaveChanges();
        }
    }

    /* 
     * /// - лучше создать классы:
     *          - TestForData (int Id, string Title, string Author, TimeSpan Time, +++ int QuestionQty, List<QuestionForData> Questions )
     *          - QuestionForData (int QuestionId, int? AnswearId) // эти только в Data: string Question, List<AnswearForData> Answears)
     *          - AnswearForData (int Id, string Description)
     * 
     * /// - Data - нужно доработать/изменить: 
     *          - вместо некоторых bool лучше сделать enum
     *          - классы что сверху с списке
     *               - что должно позволить переходить клиенту переходить по вопросам не только в одном направлении
     *               - соответственно изменить clientApp
     * 
     * /// - в Server:
     *          - добавить numericDropDown на количество одновременно прослушиваемых соединений
     *          - если была попытка сдачи теста значение isPassed изменить на = true
     * /// - в Test: 
     *          - Download: numericDropDown.readonly изменить на = false
     *          - клиенту давать доступ сдавать тест только если isPassed = false
     * /// - в Result: 
     *          - просмотр результатов по группам, а не все вместе
     *          - в бд добавить колонку bool isPassed сдавал ли тест?
     *          - добавить возможность менять upload для isPassed - возможность ещё одной попытки сдачи теста
     * /// - для бд добать таблицу Mark:
     *          - по ней высчитывается оценка за тестирование
     *          - возможность её редактирования и связывания с определённым тестом
     * /// UI тоесть дизайнер тестов добавить в окно редактора тестов возможность добавления вопросов и ответов
     * 
     * /// /// /// /// /// возможно перейти на dapperORM 
     */
    [Serializable]
    public class TestForData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public TimeSpan Time { get; set; }
    }
    [Serializable]
    public class AnswearForData
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
    [Serializable]
    public class Data
    {
        public string Token { get; set; }
        public bool IsWorking { get; set; }
        public bool IsTest { get; set; }
        public bool IsPassing { get; set; }
        public bool IsStart { get; set; }
        public bool IsLast { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<TestForData> Tests { get; set; }
        public int TestId { get; set; }
        public List<string> Groups { get; set; }
        public string Group { get; set; }
        public bool IsGroup { get; set; }

        public int? QuestionId { get; set; }
        public int QuestionQty { get; set; }
        public string Question { get; set; }
        public List<AnswearForData> Answears { get; set; }
        public int? AnswearId { get; set; }

        public int ResultMark { get; set; }
        public int QtyOfRightAnswers { get; set; }
    }
    public enum Request
    {
        Working = 0,
        Group = 1,
        Test = 2,
        QuestionStart = 3,
        QuestionNext = 4,
        QuestionLast = 5
    }
    public class ClientObject
    {
        public string Text { get; set; }
        public TcpClient client;
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }
        public ClientObject(TcpClient tcpClient, string Text)
        {
            client = tcpClient;
            this.Text = Text;
        }

        public void Process2()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();

                    Console.WriteLine(message);
                    // отправляем обратно сообщение в верхнем регистре
                    message = message.Substring(message.IndexOf(':') + 1).Trim().ToUpper();
                    data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();

                while (true)
                {
                    Data obj = null;
                    byte[] data = null; // буфер для получаемых данных
                    // получаем сообщение
                    if (stream.DataAvailable)
                    {
                        obj = (Data)new BinaryFormatter().Deserialize(stream);

                    }
                    //do smth

                    // отправляем обратно сообщение в верхнем регистре
                    BinaryFormatter bf = new BinaryFormatter();
                    using (var ms = new MemoryStream())
                    {
                        bf.Serialize(ms, obj);
                        data = ms.ToArray();
                        stream.Write(data, 0, data.Length);
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally
            {
                if (stream != null) stream.Close();
                if (client != null) client.Close();
            }
        }
    }
}
