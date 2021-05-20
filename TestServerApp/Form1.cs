using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace TestServerApp
{
    public partial class Form1 : Form
    {
        #region InitializeNewComponent
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.Panel panelConnectionString;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private void InitializeNewComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelConnectionString = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.groupBoxServer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelConnectionString.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(382, 23);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxServer.Controls.Add(this.textBoxPassword);
            this.groupBoxServer.Controls.Add(this.textBoxLogin);
            this.groupBoxServer.Controls.Add(this.buttonSignIn);
            this.groupBoxServer.Controls.Add(this.label2);
            this.groupBoxServer.Controls.Add(this.label1);
            this.groupBoxServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxServer.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxServer.Location = new System.Drawing.Point(13, 24);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(389, 176);
            this.groupBoxServer.TabIndex = 1;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Server";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPassword.Location = new System.Drawing.Point(154, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '#';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "1";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLogin.Location = new System.Drawing.Point(154, 38);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(214, 22);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "admin";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignIn.Location = new System.Drawing.Point(154, 118);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(84, 31);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.connectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionStringToolStripMenuItem_Click);
            // 
            // panelConnectionString
            // 
            this.panelConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnectionString.Controls.Add(this.buttonCancel);
            this.panelConnectionString.Controls.Add(this.buttonConnect);
            this.panelConnectionString.Controls.Add(this.label3);
            this.panelConnectionString.Controls.Add(this.textBoxConnectionString);
            this.panelConnectionString.Location = new System.Drawing.Point(0, 0);
            this.panelConnectionString.Name = "panelConnectionString";
            this.panelConnectionString.Size = new System.Drawing.Size(414, 203);
            this.panelConnectionString.TabIndex = 3;
            this.panelConnectionString.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(297, 166);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.Location = new System.Drawing.Point(37, 166);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connection String";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(13, 38);
            this.textBoxConnectionString.Multiline = true;
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConnectionString.Size = new System.Drawing.Size(389, 98);
            this.textBoxConnectionString.TabIndex = 0;
            this.textBoxConnectionString.Text = "\r\n";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(414, 201);
            this.Controls.Add(this.panelConnectionString);
            this.Controls.Add(this.groupBoxServer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 240);
            this.MinimumSize = new System.Drawing.Size(430, 240);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelConnectionString.ResumeLayout(false);
            this.panelConnectionString.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion InitializeNewComponent

        /* Test Server
         * 1. Вхід(тільки адміни)
         * 2.Створення користувачів та груп(додавання користувачів до групи)
         * 3. Завантаження тесту на сервер
         * 4. Призначити тест користувачеві, або групі
         * 5. Проглянути результати тестування
         * 6. Тестування!!!
         */

        //MessageBox.Show(Application.ProductName +
        //        "\nVersion: " + Application.ProductVersion +
        //        "\nРазработчик: " + Application.CompanyName,
        //        this.ProgName, MessageBoxButtons.OK,
        //        MessageBoxIcon.Information);

        string Connection = null;
        DALServerDB.Infrastructure.User User = null;

        RepositoryLibrary.GenericUnitOfWork work;
        RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.User> repUs;

        public Form1()
        {
            InitializeComponent();
            InitializeNewComponent();

            this.Text = "Server";
            string currentDir = Directory.GetCurrentDirectory();
            //string currentDir = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory())?.FullName)?.FullName;
            textBoxConnectionString.Text =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                currentDir +
                "\\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem m in menuStrip1.Items)
            {
                DALServerDB.Models.SetWhiteToolStrip.SetWhiteColor(m);
            }
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new DALServerDB.Models.Cols());
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            /// delete next 2 lines
                work = new RepositoryLibrary.GenericUnitOfWork(new DALServerDB.ServerContext(textBoxConnectionString.Text));
                repUs = work.Repository<DALServerDB.Infrastructure.User>();
            ///
            Connection = textBoxConnectionString.Text;
            if (work == null)
            {
                MessageBox.Show("no Connection!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("enter the Login and Password!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GetUserAdminAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetUserAdminAsync()
        {
            await Task.Run(() => GetUserAdmin());
        }
        private void GetUserAdmin()
        {
            menuStrip1.Invoke(new Action(() => menuStrip1.Enabled = false));
            buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = false));
            textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = false));
            textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = false));
            IEnumerable<DALServerDB.Infrastructure.User> user1 = repUs.FindAll(p => p.Login == textBoxLogin.Text && p.IsAdmin == true);
            if (user1 != null) User = user1.FirstOrDefault(x => DALServerDB.Models.Crypter.GetCrypt(x.Password) == textBoxPassword.Text);
            if (User == null)
            {
                MessageBox.Show(Environment.NewLine + "user not found!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                menuStrip1.Invoke(new Action(() => menuStrip1.Enabled = true));
                buttonSignIn.Invoke(new Action(() => buttonSignIn.Enabled = true));
                textBoxLogin.Invoke(new Action(() => textBoxLogin.Enabled = true));
                textBoxPassword.Invoke(new Action(() => textBoxPassword.Enabled = true));
                return;
            }
            if (User.IsAdmin)
            {
                this.Invoke(new Action(() =>
                {
                    FormMain form = new FormMain(User, Connection);
                    form.Owner = this;
                    this.Hide();
                    form.ShowDialog();
                }));
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxConnectionString.Text))
            {
                MessageBox.Show("enter a ConnectionString!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panelConnectionString.Visible = false;
            groupBoxServer.Visible = true;
            try
            {
                work = new RepositoryLibrary.GenericUnitOfWork(new DALServerDB.ServerContext(textBoxConnectionString.Text));
                repUs = work.Repository<DALServerDB.Infrastructure.User>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void connectionStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelConnectionString.Visible = true;
            groupBoxServer.Visible = false;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelConnectionString.Visible = false;
            groupBoxServer.Visible = true;
        }
    }
}
