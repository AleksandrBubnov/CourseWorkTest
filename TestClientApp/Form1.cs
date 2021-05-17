using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClientApp
{
    public partial class Form1 : Form
    {
        /* 
         * Test Client
         * 1. Вхід(перевірка входу через сервер, не напряму до бази даних)
         * 2. Вибір тесту
         * 3. Тестування(Клієнту сервер надсилає питання, без вказання правильної відповіді.
         * 4. Запис та перевірка правильності відпові на питання здійснюється на сервері)
         * 5. Клієнт слідкує за часом проходження тесту.
         * 6. В клієнті відображається результат тестування, без вказання правильних відповідей. 
         * На сервері в базі даних зберігається інформація про тестування
         */

        //MessageBox.Show(Application.ProductName +
        //        "\nVersion: " + Application.ProductVersion +
        //        "\nРазработчик: " + Application.CompanyName,
        //        this.ProgName, MessageBoxButtons.OK,
        //        MessageBoxIcon.Information);

        public Form1()
        {
            InitializeComponent();

            //string currentDir = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory())?.FullName)?.FullName;
            //textBoxConnectionString.Text =
            //    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
            //    currentDir +
            //    "\\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem m in menuStrip1.Items)
            {
                DALServerDB.Models.SetWhiteToolStrip.SetWhiteColor(m);
            }
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new DALServerDB.Models.Cols());

            ButtonSignInEnabled();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //Connection = textBoxConnectionString.Text;
            //if (work == null)
            //{
            //    MessageBox.Show("no Connection!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            //{
            //    MessageBox.Show("enter the Login and Password!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //try
            //{
            //    //user = repUs.FindAll(p => p.Login == textBoxLogin.Text && p.Password == textBoxLogin.Text).FirstOrDefault();
            //    GetUserAdminAsync();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            ButtonSignInEnabled();
        }
        private void ButtonSignInEnabled()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
                buttonSignIn.Enabled = false;
            else buttonSignIn.Enabled = true;
        }

        private async void GetUserAdminAsync()
        {
            await Task.Run(() => GetUserAdmin());
        }
        private void GetUserAdmin()
        {
            //buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = false));
            //textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = false));
            //textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = false));
            //IEnumerable<DALServerDB.User> user1 = repUs.FindAll(p => p.Login == textBoxLogin.Text && p.IsAdmin == true);
            //if (user1 != null) User = user1.FirstOrDefault(x => DALServerDB.Crypter.GetCrypt(x.Password) == textBoxPassword.Text);
            //if (User == null)
            //{
            //    MessageBox.Show(Environment.NewLine + "user not found!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = true));
            //    textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = true));
            //    textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = true));
            //    return;
            //}
            //if (User.IsAdmin)
            //{
            //    this.Invoke(new Action(() =>
            //    {
            //        FormMain form = new FormMain(User, Connection);
            //        form.Owner = this;
            //        this.Hide();
            //        form.ShowDialog();
            //    }));
            //}
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxConnectionString.Text))
            //{
            //    MessageBox.Show("enter a ConnectionString!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //panelConnectionString.Visible = false;
            //groupBoxServer.Visible = true;
            //try
            //{
            //    work = new RepositoryLibrary.GenericUnitOfWork(new DALServerDB.ServerContext(textBoxConnectionString.Text));
            //    repUs = work.Repository<DALServerDB.User>();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelConnection.Visible = true;
            groupBoxClient.Visible = false;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelConnection.Visible = false;
            groupBoxClient.Visible = true;
        }
    }
}
