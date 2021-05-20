using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
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


        TcpClient client = null;

        public Form1()
        {
            InitializeComponent();
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
            if (string.IsNullOrWhiteSpace(textBoxHostName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPortNumber.Text))
            {
                MessageBox.Show("String Connection IsNullOrWhiteSpace!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("enter the Login and Password!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetUserAsync();
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

        private async void GetUserAsync()
        {
            await Task.Run(() => GetUser());
        }
        private void GetUser()
        {
            menuStrip1.Invoke(new Action(() => menuStrip1.Enabled = false));
            buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = false));
            textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = false));
            textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = false));

            DALServerDB.Data Data = new DALServerDB.Data();
            Data.Login = textBoxLogin.Text;
            Data.Password = textBoxPassword.Text;

            string localAddr = textBoxHostName.Text;
            int port = int.Parse(textBoxPortNumber.Text);
            try
            {
                client = new TcpClient(localAddr, port);
                using (NetworkStream stream = client.GetStream())
                {
                    //using (var ms = new MemoryStream())
                    //{
                    //    new BinaryFormatter().Serialize(ms, Data);
                    //    buffer = ms.ToArray();
                    //}
                    // отправка сообщения
                    //stream.Write(buffer, 0, buffer.Length);

                    new BinaryFormatter().Serialize(client.GetStream(), Data);


                    // получаем ответ
                    Data = (DALServerDB.Data)new BinaryFormatter().Deserialize(stream);

                    if (Data.Token == null)
                    {
                        MessageBox.Show(Environment.NewLine + "user not found!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnabledComponent();
                        return;
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            FormClientMain form = new FormClientMain(Data, stream, client);
                            form.Owner = this;
                            this.Hide();
                            form.ShowDialog();
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                EnabledComponent();
                MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch { EnabledComponent(); }
        }
        private void EnabledComponent()
        {
            menuStrip1.Invoke(new Action(() => menuStrip1.Enabled = true));
            buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = true));
            textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = true));
            textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = true));
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHostName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPortNumber.Text))
            {
                MessageBox.Show("String IsNullOrWhiteSpace!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panelConnection.Visible = false;
            groupBoxClient.Visible = true;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null) client?.Close();
        }
    }
}
