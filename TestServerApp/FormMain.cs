using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TestServerApp
{
    public partial class FormMain : Form
    {
        #region InitializeNewComponent

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label labelIsAdmin;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Label labelFLName;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxServer;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.SplitContainer splitContainerDG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelUpdateUser;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.TextBox textBoxConfPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCanselUpdateUser;
        private System.Windows.Forms.Button buttonOkUpdateUser;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelShowUserOfGroup;
        private System.Windows.Forms.ComboBox comboBoxShowUserOfGroup;
        private System.Windows.Forms.Button buttonRemoveUserOfGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAddNewUser;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.ComboBox comboBoxAddNewUser;
        private System.Windows.Forms.Panel panelAddGroup;
        private System.Windows.Forms.Button buttonCanselAddGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxbuttonlAddGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelShowAllGroup;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.Panel panelLoadTest;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonCanselLoadTest;
        private System.Windows.Forms.Button buttonOkLoadTest;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxQtyOfQues;
        private System.Windows.Forms.TextBox textBoxNameT;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelAsignTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelUpgradeGroup;
        private System.Windows.Forms.Button buttonlCanselUpgradeGroup;
        private System.Windows.Forms.Button buttonlUpgradeGroup;
        private System.Windows.Forms.TextBox textBoxUpgradeGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelShowAllUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Panel panelTestFoGroup;
        private System.Windows.Forms.ComboBox comboBoxTestFoGroup;
        private System.Windows.Forms.Button buttonRemoveTestFoGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelShowTests;
        private System.Windows.Forms.Button buttonRemoveTest;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.CheckBox checkBoxIsAdminAddUser;
        private System.Windows.Forms.TextBox textBoxConfPaswAddUser;
        private System.Windows.Forms.TextBox textBoxPasswAddUser;
        private System.Windows.Forms.TextBox textBoxLoginAddUser;
        private System.Windows.Forms.TextBox textBoxLNAddUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonCanselAddUser;
        private System.Windows.Forms.Button buttonOkAddUser;
        private System.Windows.Forms.TextBox textBoxFNAddUser;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Panel panelFilterTest;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxTestTitle;
        private System.Windows.Forms.Panel panelServerSettings;
        private System.Windows.Forms.TextBox textBoxPortNumber;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numericUpDownNIC;

        private void InitializeNewComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.labelFLName = new System.Windows.Forms.Label();
            this.labelIsAdmin = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.listBoxServer = new System.Windows.Forms.ListBox();
            this.buttonServer = new System.Windows.Forms.Button();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.buttonTests = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelSelected = new System.Windows.Forms.Label();
            this.splitContainerDG = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelServerSettings = new System.Windows.Forms.Panel();
            this.numericUpDownNIC = new System.Windows.Forms.NumericUpDown();
            this.textBoxPortNumber = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panelFilterTest = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxTestTitle = new System.Windows.Forms.ComboBox();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.checkBoxIsAdminAddUser = new System.Windows.Forms.CheckBox();
            this.textBoxConfPaswAddUser = new System.Windows.Forms.TextBox();
            this.textBoxPasswAddUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginAddUser = new System.Windows.Forms.TextBox();
            this.textBoxLNAddUser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonCanselAddUser = new System.Windows.Forms.Button();
            this.buttonOkAddUser = new System.Windows.Forms.Button();
            this.textBoxFNAddUser = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panelTestFoGroup = new System.Windows.Forms.Panel();
            this.comboBoxTestFoGroup = new System.Windows.Forms.ComboBox();
            this.buttonRemoveTestFoGroup = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panelShowTests = new System.Windows.Forms.Panel();
            this.buttonRemoveTest = new System.Windows.Forms.Button();
            this.panelShowAllUser = new System.Windows.Forms.Panel();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.panelUpgradeGroup = new System.Windows.Forms.Panel();
            this.buttonlCanselUpgradeGroup = new System.Windows.Forms.Button();
            this.buttonlUpgradeGroup = new System.Windows.Forms.Button();
            this.textBoxUpgradeGroup = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelAsignTest = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panelLoadTest = new System.Windows.Forms.Panel();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxQtyOfQues = new System.Windows.Forms.TextBox();
            this.textBoxNameT = new System.Windows.Forms.TextBox();
            this.buttonCanselLoadTest = new System.Windows.Forms.Button();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonOkLoadTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.panelUpdateUser = new System.Windows.Forms.Panel();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxConfPass = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCanselUpdateUser = new System.Windows.Forms.Button();
            this.buttonOkUpdateUser = new System.Windows.Forms.Button();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelShowUserOfGroup = new System.Windows.Forms.Panel();
            this.comboBoxShowUserOfGroup = new System.Windows.Forms.ComboBox();
            this.buttonRemoveUserOfGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddNewUser = new System.Windows.Forms.Panel();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.comboBoxAddNewUser = new System.Windows.Forms.ComboBox();
            this.panelAddGroup = new System.Windows.Forms.Panel();
            this.buttonCanselAddGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textBoxbuttonlAddGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShowAllGroup = new System.Windows.Forms.Panel();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDG)).BeginInit();
            this.splitContainerDG.Panel1.SuspendLayout();
            this.splitContainerDG.Panel2.SuspendLayout();
            this.splitContainerDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelServerSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIC)).BeginInit();
            this.panelFilterTest.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panelTestFoGroup.SuspendLayout();
            this.panelShowTests.SuspendLayout();
            this.panelShowAllUser.SuspendLayout();
            this.panelUpgradeGroup.SuspendLayout();
            this.panelAsignTest.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelLoadTest.SuspendLayout();
            this.groupBoxServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.panelUpdateUser.SuspendLayout();
            this.panelShowUserOfGroup.SuspendLayout();
            this.panelAddNewUser.SuspendLayout();
            this.panelAddGroup.SuspendLayout();
            this.panelShowAllGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 539);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 539);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.labelFLName);
            this.splitContainer3.Panel1.Controls.Add(this.labelIsAdmin);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.listBoxResult);
            this.splitContainer3.Panel2.Controls.Add(this.buttonResult);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxServer);
            this.splitContainer3.Panel2.Controls.Add(this.buttonServer);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxTests);
            this.splitContainer3.Panel2.Controls.Add(this.buttonTests);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxUsers);
            this.splitContainer3.Panel2.Controls.Add(this.buttonUsers);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxGroups);
            this.splitContainer3.Panel2.Controls.Add(this.buttonGroups);
            this.splitContainer3.Size = new System.Drawing.Size(268, 539);
            this.splitContainer3.SplitterDistance = 67;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // labelFLName
            // 
            this.labelFLName.AutoSize = true;
            this.labelFLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFLName.ForeColor = System.Drawing.Color.Aqua;
            this.labelFLName.Location = new System.Drawing.Point(12, 34);
            this.labelFLName.Name = "labelFLName";
            this.labelFLName.Size = new System.Drawing.Size(93, 25);
            this.labelFLName.TabIndex = 1;
            this.labelFLName.Text = "FLName";
            // 
            // labelIsAdmin
            // 
            this.labelIsAdmin.AutoSize = true;
            this.labelIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsAdmin.ForeColor = System.Drawing.Color.Aqua;
            this.labelIsAdmin.Location = new System.Drawing.Point(12, 9);
            this.labelIsAdmin.Name = "labelIsAdmin";
            this.labelIsAdmin.Size = new System.Drawing.Size(88, 25);
            this.labelIsAdmin.TabIndex = 0;
            this.labelIsAdmin.Text = "isAdmin";
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxResult.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.HorizontalScrollbar = true;
            this.listBoxResult.ItemHeight = 15;
            this.listBoxResult.Location = new System.Drawing.Point(0, 483);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(251, 92);
            this.listBoxResult.TabIndex = 11;
            this.listBoxResult.Visible = false;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Location = new System.Drawing.Point(0, 460);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(251, 23);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "Result";
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // listBoxServer
            // 
            this.listBoxServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxServer.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxServer.FormattingEnabled = true;
            this.listBoxServer.HorizontalScrollbar = true;
            this.listBoxServer.ItemHeight = 15;
            this.listBoxServer.Location = new System.Drawing.Point(0, 368);
            this.listBoxServer.Name = "listBoxServer";
            this.listBoxServer.Size = new System.Drawing.Size(251, 92);
            this.listBoxServer.TabIndex = 9;
            this.listBoxServer.Visible = false;
            this.listBoxServer.SelectedIndexChanged += new System.EventHandler(this.listBoxServer_SelectedIndexChanged);
            // 
            // buttonServer
            // 
            this.buttonServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.buttonServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonServer.Location = new System.Drawing.Point(0, 345);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(251, 23);
            this.buttonServer.TabIndex = 8;
            this.buttonServer.Text = "Server";
            this.buttonServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServer.UseVisualStyleBackColor = false;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // listBoxTests
            // 
            this.listBoxTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxTests.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.HorizontalScrollbar = true;
            this.listBoxTests.ItemHeight = 15;
            this.listBoxTests.Location = new System.Drawing.Point(0, 253);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(251, 92);
            this.listBoxTests.TabIndex = 7;
            this.listBoxTests.Visible = false;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            // 
            // buttonTests
            // 
            this.buttonTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.buttonTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTests.Location = new System.Drawing.Point(0, 230);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(251, 23);
            this.buttonTests.TabIndex = 6;
            this.buttonTests.Text = "Tests";
            this.buttonTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTests.UseVisualStyleBackColor = false;
            this.buttonTests.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.HorizontalScrollbar = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(0, 138);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(251, 92);
            this.listBoxUsers.TabIndex = 5;
            this.listBoxUsers.Visible = false;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsers.Location = new System.Drawing.Point(0, 115);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(251, 23);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxGroups.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.HorizontalScrollbar = true;
            this.listBoxGroups.ItemHeight = 15;
            this.listBoxGroups.Location = new System.Drawing.Point(0, 23);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(251, 92);
            this.listBoxGroups.TabIndex = 3;
            this.listBoxGroups.Visible = false;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGroups.Location = new System.Drawing.Point(0, 0);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(251, 23);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.labelSelected);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.splitContainer2.Panel2.Controls.Add(this.splitContainerDG);
            this.splitContainer2.Size = new System.Drawing.Size(512, 539);
            this.splitContainer2.SplitterDistance = 66;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelected.ForeColor = System.Drawing.Color.Aqua;
            this.labelSelected.Location = new System.Drawing.Point(3, 9);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(96, 25);
            this.labelSelected.TabIndex = 1;
            this.labelSelected.Text = "Selected";
            // 
            // splitContainerDG
            // 
            this.splitContainerDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDG.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerDG.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDG.Name = "splitContainerDG";
            this.splitContainerDG.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDG.Panel1
            // 
            this.splitContainerDG.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainerDG.Panel1Collapsed = true;
            // 
            // splitContainerDG.Panel2
            // 
            this.splitContainerDG.Panel2.AutoScroll = true;
            this.splitContainerDG.Panel2.Controls.Add(this.panelServerSettings);
            this.splitContainerDG.Panel2.Controls.Add(this.panelFilterTest);
            this.splitContainerDG.Panel2.Controls.Add(this.panelAddUser);
            this.splitContainerDG.Panel2.Controls.Add(this.panelTestFoGroup);
            this.splitContainerDG.Panel2.Controls.Add(this.panelShowTests);
            this.splitContainerDG.Panel2.Controls.Add(this.panelShowAllUser);
            this.splitContainerDG.Panel2.Controls.Add(this.panelUpgradeGroup);
            this.splitContainerDG.Panel2.Controls.Add(this.panelAsignTest);
            this.splitContainerDG.Panel2.Controls.Add(this.panelLoadTest);
            this.splitContainerDG.Panel2.Controls.Add(this.panelUpdateUser);
            this.splitContainerDG.Panel2.Controls.Add(this.panelShowUserOfGroup);
            this.splitContainerDG.Panel2.Controls.Add(this.panelAddNewUser);
            this.splitContainerDG.Panel2.Controls.Add(this.panelAddGroup);
            this.splitContainerDG.Panel2.Controls.Add(this.panelShowAllGroup);
            this.splitContainerDG.Size = new System.Drawing.Size(512, 469);
            this.splitContainerDG.SplitterDistance = 268;
            this.splitContainerDG.SplitterWidth = 8;
            this.splitContainerDG.TabIndex = 6;
            this.splitContainerDG.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(490, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 266);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panelServerSettings
            // 
            this.panelServerSettings.Controls.Add(this.numericUpDownNIC);
            this.panelServerSettings.Controls.Add(this.textBoxPortNumber);
            this.panelServerSettings.Controls.Add(this.label25);
            this.panelServerSettings.Controls.Add(this.label26);
            this.panelServerSettings.Controls.Add(this.buttonStop);
            this.panelServerSettings.Controls.Add(this.buttonStart);
            this.panelServerSettings.Controls.Add(this.textBoxHostName);
            this.panelServerSettings.Controls.Add(this.label27);
            this.panelServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServerSettings.Location = new System.Drawing.Point(0, 1527);
            this.panelServerSettings.Name = "panelServerSettings";
            this.panelServerSettings.Size = new System.Drawing.Size(493, 167);
            this.panelServerSettings.TabIndex = 19;
            this.panelServerSettings.Visible = false;
            // 
            // numericUpDownNIC
            // 
            this.numericUpDownNIC.Location = new System.Drawing.Point(142, 77);
            this.numericUpDownNIC.Name = "numericUpDownNIC";
            this.numericUpDownNIC.ReadOnly = true;
            this.numericUpDownNIC.Size = new System.Drawing.Size(75, 21);
            this.numericUpDownNIC.TabIndex = 22;
            this.numericUpDownNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNIC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNIC.Visible = false;
            // 
            // textBoxPortNumber
            // 
            this.textBoxPortNumber.Location = new System.Drawing.Point(142, 49);
            this.textBoxPortNumber.Name = "textBoxPortNumber";
            this.textBoxPortNumber.Size = new System.Drawing.Size(341, 21);
            this.textBoxPortNumber.TabIndex = 2;
            this.textBoxPortNumber.Text = "33000";
            this.textBoxPortNumber.TextChanged += new System.EventHandler(this.textBoxHostName_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 15);
            this.label25.TabIndex = 5;
            this.label25.Text = "NIC (from 0)";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 4;
            this.label26.Text = "Port number";
            // 
            // buttonStop
            // 
            this.buttonStop.AutoSize = true;
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Location = new System.Drawing.Point(384, 128);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(99, 25);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Location = new System.Drawing.Point(142, 128);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(99, 25);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(142, 21);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.ReadOnly = true;
            this.textBoxHostName.Size = new System.Drawing.Size(341, 21);
            this.textBoxHostName.TabIndex = 1;
            this.textBoxHostName.Text = "127.0.0.1";
            this.textBoxHostName.TextChanged += new System.EventHandler(this.textBoxHostName_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 15);
            this.label27.TabIndex = 0;
            this.label27.Text = "Host IPAddress";
            // 
            // panelFilterTest
            // 
            this.panelFilterTest.Controls.Add(this.label22);
            this.panelFilterTest.Controls.Add(this.comboBoxTestTitle);
            this.panelFilterTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterTest.Location = new System.Drawing.Point(0, 1487);
            this.panelFilterTest.Name = "panelFilterTest";
            this.panelFilterTest.Size = new System.Drawing.Size(493, 40);
            this.panelFilterTest.TabIndex = 18;
            this.panelFilterTest.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Test title";
            // 
            // comboBoxTestTitle
            // 
            this.comboBoxTestTitle.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTestTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTestTitle.FormattingEnabled = true;
            this.comboBoxTestTitle.Location = new System.Drawing.Point(142, 10);
            this.comboBoxTestTitle.Name = "comboBoxTestTitle";
            this.comboBoxTestTitle.Size = new System.Drawing.Size(341, 23);
            this.comboBoxTestTitle.TabIndex = 0;
            this.comboBoxTestTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestTitle_SelectedIndexChanged);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.checkBoxIsAdminAddUser);
            this.panelAddUser.Controls.Add(this.textBoxConfPaswAddUser);
            this.panelAddUser.Controls.Add(this.textBoxPasswAddUser);
            this.panelAddUser.Controls.Add(this.textBoxLoginAddUser);
            this.panelAddUser.Controls.Add(this.textBoxLNAddUser);
            this.panelAddUser.Controls.Add(this.label17);
            this.panelAddUser.Controls.Add(this.label18);
            this.panelAddUser.Controls.Add(this.label19);
            this.panelAddUser.Controls.Add(this.label20);
            this.panelAddUser.Controls.Add(this.buttonCanselAddUser);
            this.panelAddUser.Controls.Add(this.buttonOkAddUser);
            this.panelAddUser.Controls.Add(this.textBoxFNAddUser);
            this.panelAddUser.Controls.Add(this.label21);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddUser.Location = new System.Drawing.Point(0, 1246);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(493, 241);
            this.panelAddUser.TabIndex = 17;
            this.panelAddUser.Visible = false;
            // 
            // checkBoxIsAdminAddUser
            // 
            this.checkBoxIsAdminAddUser.AutoSize = true;
            this.checkBoxIsAdminAddUser.Location = new System.Drawing.Point(142, 161);
            this.checkBoxIsAdminAddUser.Name = "checkBoxIsAdminAddUser";
            this.checkBoxIsAdminAddUser.Size = new System.Drawing.Size(61, 19);
            this.checkBoxIsAdminAddUser.TabIndex = 6;
            this.checkBoxIsAdminAddUser.Text = "Admin";
            this.checkBoxIsAdminAddUser.UseVisualStyleBackColor = true;
            // 
            // textBoxConfPaswAddUser
            // 
            this.textBoxConfPaswAddUser.Location = new System.Drawing.Point(142, 133);
            this.textBoxConfPaswAddUser.Name = "textBoxConfPaswAddUser";
            this.textBoxConfPaswAddUser.Size = new System.Drawing.Size(341, 21);
            this.textBoxConfPaswAddUser.TabIndex = 5;
            this.textBoxConfPaswAddUser.TextChanged += new System.EventHandler(this.textBoxFNAddUser_TextChanged);
            // 
            // textBoxPasswAddUser
            // 
            this.textBoxPasswAddUser.Location = new System.Drawing.Point(142, 105);
            this.textBoxPasswAddUser.Name = "textBoxPasswAddUser";
            this.textBoxPasswAddUser.Size = new System.Drawing.Size(341, 21);
            this.textBoxPasswAddUser.TabIndex = 4;
            this.textBoxPasswAddUser.TextChanged += new System.EventHandler(this.textBoxFNAddUser_TextChanged);
            // 
            // textBoxLoginAddUser
            // 
            this.textBoxLoginAddUser.Location = new System.Drawing.Point(142, 77);
            this.textBoxLoginAddUser.Name = "textBoxLoginAddUser";
            this.textBoxLoginAddUser.Size = new System.Drawing.Size(341, 21);
            this.textBoxLoginAddUser.TabIndex = 3;
            this.textBoxLoginAddUser.TextChanged += new System.EventHandler(this.textBoxFNAddUser_TextChanged);
            // 
            // textBoxLNAddUser
            // 
            this.textBoxLNAddUser.Location = new System.Drawing.Point(142, 49);
            this.textBoxLNAddUser.Name = "textBoxLNAddUser";
            this.textBoxLNAddUser.Size = new System.Drawing.Size(341, 21);
            this.textBoxLNAddUser.TabIndex = 2;
            this.textBoxLNAddUser.TextChanged += new System.EventHandler(this.textBoxFNAddUser_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "Confirm password";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Password";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 15);
            this.label19.TabIndex = 5;
            this.label19.Text = "Login";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Last Name";
            // 
            // buttonCanselAddUser
            // 
            this.buttonCanselAddUser.AutoSize = true;
            this.buttonCanselAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCanselAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanselAddUser.Location = new System.Drawing.Point(384, 208);
            this.buttonCanselAddUser.Name = "buttonCanselAddUser";
            this.buttonCanselAddUser.Size = new System.Drawing.Size(99, 25);
            this.buttonCanselAddUser.TabIndex = 8;
            this.buttonCanselAddUser.Text = "Cansel";
            this.buttonCanselAddUser.UseVisualStyleBackColor = false;
            this.buttonCanselAddUser.Click += new System.EventHandler(this.buttonCanselAddUser_Click);
            // 
            // buttonOkAddUser
            // 
            this.buttonOkAddUser.AutoSize = true;
            this.buttonOkAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOkAddUser.Enabled = false;
            this.buttonOkAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOkAddUser.Location = new System.Drawing.Point(142, 208);
            this.buttonOkAddUser.Name = "buttonOkAddUser";
            this.buttonOkAddUser.Size = new System.Drawing.Size(99, 25);
            this.buttonOkAddUser.TabIndex = 7;
            this.buttonOkAddUser.Text = "Add user";
            this.buttonOkAddUser.UseVisualStyleBackColor = false;
            this.buttonOkAddUser.Click += new System.EventHandler(this.buttonOkAddUser_Click);
            // 
            // textBoxFNAddUser
            // 
            this.textBoxFNAddUser.Location = new System.Drawing.Point(142, 21);
            this.textBoxFNAddUser.Name = "textBoxFNAddUser";
            this.textBoxFNAddUser.Size = new System.Drawing.Size(341, 21);
            this.textBoxFNAddUser.TabIndex = 1;
            this.textBoxFNAddUser.TextChanged += new System.EventHandler(this.textBoxFNAddUser_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "First Name";
            // 
            // panelTestFoGroup
            // 
            this.panelTestFoGroup.Controls.Add(this.comboBoxTestFoGroup);
            this.panelTestFoGroup.Controls.Add(this.buttonRemoveTestFoGroup);
            this.panelTestFoGroup.Controls.Add(this.label16);
            this.panelTestFoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTestFoGroup.Location = new System.Drawing.Point(0, 1157);
            this.panelTestFoGroup.Name = "panelTestFoGroup";
            this.panelTestFoGroup.Size = new System.Drawing.Size(493, 89);
            this.panelTestFoGroup.TabIndex = 16;
            this.panelTestFoGroup.Visible = false;
            // 
            // comboBoxTestFoGroup
            // 
            this.comboBoxTestFoGroup.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTestFoGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestFoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTestFoGroup.FormattingEnabled = true;
            this.comboBoxTestFoGroup.Location = new System.Drawing.Point(142, 20);
            this.comboBoxTestFoGroup.Name = "comboBoxTestFoGroup";
            this.comboBoxTestFoGroup.Size = new System.Drawing.Size(341, 23);
            this.comboBoxTestFoGroup.TabIndex = 4;
            this.comboBoxTestFoGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestFoGroup_SelectedIndexChanged);
            // 
            // buttonRemoveTestFoGroup
            // 
            this.buttonRemoveTestFoGroup.AutoSize = true;
            this.buttonRemoveTestFoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRemoveTestFoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveTestFoGroup.Location = new System.Drawing.Point(10, 58);
            this.buttonRemoveTestFoGroup.Name = "buttonRemoveTestFoGroup";
            this.buttonRemoveTestFoGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonRemoveTestFoGroup.TabIndex = 3;
            this.buttonRemoveTestFoGroup.Text = "Remove test";
            this.buttonRemoveTestFoGroup.UseVisualStyleBackColor = false;
            this.buttonRemoveTestFoGroup.Click += new System.EventHandler(this.buttonRemoveTestFoGroup_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name of group";
            // 
            // panelShowTests
            // 
            this.panelShowTests.Controls.Add(this.buttonRemoveTest);
            this.panelShowTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowTests.Location = new System.Drawing.Point(0, 1117);
            this.panelShowTests.Name = "panelShowTests";
            this.panelShowTests.Size = new System.Drawing.Size(493, 40);
            this.panelShowTests.TabIndex = 15;
            this.panelShowTests.Visible = false;
            // 
            // buttonRemoveTest
            // 
            this.buttonRemoveTest.AutoSize = true;
            this.buttonRemoveTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRemoveTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveTest.Location = new System.Drawing.Point(10, 9);
            this.buttonRemoveTest.Name = "buttonRemoveTest";
            this.buttonRemoveTest.Size = new System.Drawing.Size(99, 25);
            this.buttonRemoveTest.TabIndex = 1;
            this.buttonRemoveTest.Text = "Remove test";
            this.buttonRemoveTest.UseVisualStyleBackColor = false;
            this.buttonRemoveTest.Click += new System.EventHandler(this.buttonRemoveTest_Click);
            // 
            // panelShowAllUser
            // 
            this.panelShowAllUser.Controls.Add(this.buttonRemoveUser);
            this.panelShowAllUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowAllUser.Location = new System.Drawing.Point(0, 1077);
            this.panelShowAllUser.Name = "panelShowAllUser";
            this.panelShowAllUser.Size = new System.Drawing.Size(493, 40);
            this.panelShowAllUser.TabIndex = 14;
            this.panelShowAllUser.Visible = false;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.AutoSize = true;
            this.buttonRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveUser.Location = new System.Drawing.Point(10, 9);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(99, 25);
            this.buttonRemoveUser.TabIndex = 1;
            this.buttonRemoveUser.Text = "Remove user";
            this.buttonRemoveUser.UseVisualStyleBackColor = false;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // panelUpgradeGroup
            // 
            this.panelUpgradeGroup.Controls.Add(this.buttonlCanselUpgradeGroup);
            this.panelUpgradeGroup.Controls.Add(this.buttonlUpgradeGroup);
            this.panelUpgradeGroup.Controls.Add(this.textBoxUpgradeGroup);
            this.panelUpgradeGroup.Controls.Add(this.label15);
            this.panelUpgradeGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpgradeGroup.Location = new System.Drawing.Point(0, 983);
            this.panelUpgradeGroup.Name = "panelUpgradeGroup";
            this.panelUpgradeGroup.Size = new System.Drawing.Size(493, 94);
            this.panelUpgradeGroup.TabIndex = 13;
            this.panelUpgradeGroup.Visible = false;
            // 
            // buttonlCanselUpgradeGroup
            // 
            this.buttonlCanselUpgradeGroup.AutoSize = true;
            this.buttonlCanselUpgradeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonlCanselUpgradeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlCanselUpgradeGroup.Location = new System.Drawing.Point(384, 57);
            this.buttonlCanselUpgradeGroup.Name = "buttonlCanselUpgradeGroup";
            this.buttonlCanselUpgradeGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonlCanselUpgradeGroup.TabIndex = 3;
            this.buttonlCanselUpgradeGroup.Text = "Cansel";
            this.buttonlCanselUpgradeGroup.UseVisualStyleBackColor = false;
            this.buttonlCanselUpgradeGroup.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonlUpgradeGroup
            // 
            this.buttonlUpgradeGroup.AutoSize = true;
            this.buttonlUpgradeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonlUpgradeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlUpgradeGroup.Location = new System.Drawing.Point(142, 57);
            this.buttonlUpgradeGroup.Name = "buttonlUpgradeGroup";
            this.buttonlUpgradeGroup.Size = new System.Drawing.Size(100, 25);
            this.buttonlUpgradeGroup.TabIndex = 2;
            this.buttonlUpgradeGroup.Text = "Upgrade group";
            this.buttonlUpgradeGroup.UseVisualStyleBackColor = false;
            this.buttonlUpgradeGroup.Click += new System.EventHandler(this.buttonlUpgradeGroup_Click);
            // 
            // textBoxUpgradeGroup
            // 
            this.textBoxUpgradeGroup.Location = new System.Drawing.Point(142, 21);
            this.textBoxUpgradeGroup.Name = "textBoxUpgradeGroup";
            this.textBoxUpgradeGroup.Size = new System.Drawing.Size(341, 21);
            this.textBoxUpgradeGroup.TabIndex = 1;
            this.textBoxUpgradeGroup.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name";
            // 
            // panelAsignTest
            // 
            this.panelAsignTest.Controls.Add(this.panel2);
            this.panelAsignTest.Controls.Add(this.comboBox3);
            this.panelAsignTest.Controls.Add(this.buttonAddTest);
            this.panelAsignTest.Controls.Add(this.label14);
            this.panelAsignTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAsignTest.Location = new System.Drawing.Point(0, 745);
            this.panelAsignTest.Name = "panelAsignTest";
            this.panelAsignTest.Size = new System.Drawing.Size(493, 238);
            this.panelAsignTest.TabIndex = 12;
            this.panelAsignTest.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 151);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(490, 176);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(629, 176);
            this.dataGridView2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(142, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(341, 23);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddTest.AutoSize = true;
            this.buttonAddTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddTest.Location = new System.Drawing.Point(7, 206);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(99, 25);
            this.buttonAddTest.TabIndex = 3;
            this.buttonAddTest.Text = "Add test";
            this.buttonAddTest.UseVisualStyleBackColor = false;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name of group";
            // 
            // panelLoadTest
            // 
            this.panelLoadTest.Controls.Add(this.groupBoxServer);
            this.panelLoadTest.Controls.Add(this.buttonFile);
            this.panelLoadTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoadTest.Location = new System.Drawing.Point(0, 504);
            this.panelLoadTest.Name = "panelLoadTest";
            this.panelLoadTest.Size = new System.Drawing.Size(493, 241);
            this.panelLoadTest.TabIndex = 11;
            this.panelLoadTest.Visible = false;
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.numericUpDownMinute);
            this.groupBoxServer.Controls.Add(this.numericUpDownHour);
            this.groupBoxServer.Controls.Add(this.label13);
            this.groupBoxServer.Controls.Add(this.label12);
            this.groupBoxServer.Controls.Add(this.label11);
            this.groupBoxServer.Controls.Add(this.textBoxQtyOfQues);
            this.groupBoxServer.Controls.Add(this.textBoxNameT);
            this.groupBoxServer.Controls.Add(this.buttonCanselLoadTest);
            this.groupBoxServer.Controls.Add(this.textBoxAuthor);
            this.groupBoxServer.Controls.Add(this.buttonOkLoadTest);
            this.groupBoxServer.Controls.Add(this.label8);
            this.groupBoxServer.Controls.Add(this.label9);
            this.groupBoxServer.Controls.Add(this.label10);
            this.groupBoxServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxServer.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxServer.Location = new System.Drawing.Point(10, 45);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(490, 176);
            this.groupBoxServer.TabIndex = 14;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Info";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(291, 105);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.ReadOnly = true;
            this.numericUpDownMinute.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownMinute.TabIndex = 22;
            this.numericUpDownMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(132, 105);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.ReadOnly = true;
            this.numericUpDownHour.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownHour.TabIndex = 21;
            this.numericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Minute";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Hour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Time";
            // 
            // textBoxQtyOfQues
            // 
            this.textBoxQtyOfQues.Location = new System.Drawing.Point(132, 77);
            this.textBoxQtyOfQues.Name = "textBoxQtyOfQues";
            this.textBoxQtyOfQues.ReadOnly = true;
            this.textBoxQtyOfQues.Size = new System.Drawing.Size(341, 22);
            this.textBoxQtyOfQues.TabIndex = 17;
            this.textBoxQtyOfQues.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // textBoxNameT
            // 
            this.textBoxNameT.Location = new System.Drawing.Point(132, 49);
            this.textBoxNameT.Name = "textBoxNameT";
            this.textBoxNameT.ReadOnly = true;
            this.textBoxNameT.Size = new System.Drawing.Size(341, 22);
            this.textBoxNameT.TabIndex = 16;
            this.textBoxNameT.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // buttonCanselLoadTest
            // 
            this.buttonCanselLoadTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCanselLoadTest.AutoSize = true;
            this.buttonCanselLoadTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCanselLoadTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanselLoadTest.Location = new System.Drawing.Point(374, 144);
            this.buttonCanselLoadTest.Name = "buttonCanselLoadTest";
            this.buttonCanselLoadTest.Size = new System.Drawing.Size(99, 26);
            this.buttonCanselLoadTest.TabIndex = 3;
            this.buttonCanselLoadTest.Text = "Cansel";
            this.buttonCanselLoadTest.UseVisualStyleBackColor = false;
            this.buttonCanselLoadTest.Click += new System.EventHandler(this.buttonCanselLoadTest_Click);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(132, 21);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(341, 22);
            this.textBoxAuthor.TabIndex = 15;
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // buttonOkLoadTest
            // 
            this.buttonOkLoadTest.AutoSize = true;
            this.buttonOkLoadTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOkLoadTest.Enabled = false;
            this.buttonOkLoadTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOkLoadTest.Location = new System.Drawing.Point(132, 144);
            this.buttonOkLoadTest.Name = "buttonOkLoadTest";
            this.buttonOkLoadTest.Size = new System.Drawing.Size(99, 26);
            this.buttonOkLoadTest.TabIndex = 2;
            this.buttonOkLoadTest.Text = "Load";
            this.buttonOkLoadTest.UseVisualStyleBackColor = false;
            this.buttonOkLoadTest.Click += new System.EventHandler(this.buttonOkLoadTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Qty of questions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name of test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Author";
            // 
            // buttonFile
            // 
            this.buttonFile.AutoSize = true;
            this.buttonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFile.Location = new System.Drawing.Point(10, 14);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(99, 25);
            this.buttonFile.TabIndex = 13;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // panelUpdateUser
            // 
            this.panelUpdateUser.Controls.Add(this.checkBoxIsAdmin);
            this.panelUpdateUser.Controls.Add(this.textBoxConfPass);
            this.panelUpdateUser.Controls.Add(this.textBoxPassword);
            this.panelUpdateUser.Controls.Add(this.textBoxLogin);
            this.panelUpdateUser.Controls.Add(this.textBoxLN);
            this.panelUpdateUser.Controls.Add(this.label7);
            this.panelUpdateUser.Controls.Add(this.label6);
            this.panelUpdateUser.Controls.Add(this.label5);
            this.panelUpdateUser.Controls.Add(this.label4);
            this.panelUpdateUser.Controls.Add(this.buttonCanselUpdateUser);
            this.panelUpdateUser.Controls.Add(this.buttonOkUpdateUser);
            this.panelUpdateUser.Controls.Add(this.textBoxFN);
            this.panelUpdateUser.Controls.Add(this.label3);
            this.panelUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdateUser.Location = new System.Drawing.Point(0, 263);
            this.panelUpdateUser.Name = "panelUpdateUser";
            this.panelUpdateUser.Size = new System.Drawing.Size(493, 241);
            this.panelUpdateUser.TabIndex = 10;
            this.panelUpdateUser.Visible = false;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(142, 161);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(61, 19);
            this.checkBoxIsAdmin.TabIndex = 6;
            this.checkBoxIsAdmin.Text = "Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxConfPass
            // 
            this.textBoxConfPass.Location = new System.Drawing.Point(142, 133);
            this.textBoxConfPass.Name = "textBoxConfPass";
            this.textBoxConfPass.Size = new System.Drawing.Size(341, 21);
            this.textBoxConfPass.TabIndex = 5;
            this.textBoxConfPass.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(142, 105);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(341, 21);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(142, 77);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(341, 21);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(142, 49);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(341, 21);
            this.textBoxLN.TabIndex = 2;
            this.textBoxLN.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Confirm password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // buttonCanselUpdateUser
            // 
            this.buttonCanselUpdateUser.AutoSize = true;
            this.buttonCanselUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCanselUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanselUpdateUser.Location = new System.Drawing.Point(384, 208);
            this.buttonCanselUpdateUser.Name = "buttonCanselUpdateUser";
            this.buttonCanselUpdateUser.Size = new System.Drawing.Size(99, 25);
            this.buttonCanselUpdateUser.TabIndex = 8;
            this.buttonCanselUpdateUser.Text = "Cansel";
            this.buttonCanselUpdateUser.UseVisualStyleBackColor = false;
            this.buttonCanselUpdateUser.Click += new System.EventHandler(this.buttonCanselUpdateUser_Click);
            // 
            // buttonOkUpdateUser
            // 
            this.buttonOkUpdateUser.AutoSize = true;
            this.buttonOkUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOkUpdateUser.Enabled = false;
            this.buttonOkUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOkUpdateUser.Location = new System.Drawing.Point(142, 208);
            this.buttonOkUpdateUser.Name = "buttonOkUpdateUser";
            this.buttonOkUpdateUser.Size = new System.Drawing.Size(99, 25);
            this.buttonOkUpdateUser.TabIndex = 7;
            this.buttonOkUpdateUser.Text = "Update user";
            this.buttonOkUpdateUser.UseVisualStyleBackColor = false;
            this.buttonOkUpdateUser.Click += new System.EventHandler(this.buttonOkUpdateUser_Click);
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(142, 21);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(341, 21);
            this.textBoxFN.TabIndex = 1;
            this.textBoxFN.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // panelShowUserOfGroup
            // 
            this.panelShowUserOfGroup.Controls.Add(this.comboBoxShowUserOfGroup);
            this.panelShowUserOfGroup.Controls.Add(this.buttonRemoveUserOfGroup);
            this.panelShowUserOfGroup.Controls.Add(this.label2);
            this.panelShowUserOfGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowUserOfGroup.Location = new System.Drawing.Point(0, 174);
            this.panelShowUserOfGroup.Name = "panelShowUserOfGroup";
            this.panelShowUserOfGroup.Size = new System.Drawing.Size(493, 89);
            this.panelShowUserOfGroup.TabIndex = 9;
            this.panelShowUserOfGroup.Visible = false;
            // 
            // comboBoxShowUserOfGroup
            // 
            this.comboBoxShowUserOfGroup.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxShowUserOfGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowUserOfGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxShowUserOfGroup.FormattingEnabled = true;
            this.comboBoxShowUserOfGroup.Location = new System.Drawing.Point(142, 20);
            this.comboBoxShowUserOfGroup.Name = "comboBoxShowUserOfGroup";
            this.comboBoxShowUserOfGroup.Size = new System.Drawing.Size(341, 23);
            this.comboBoxShowUserOfGroup.TabIndex = 4;
            this.comboBoxShowUserOfGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowUserOfGroup_SelectedIndexChanged);
            // 
            // buttonRemoveUserOfGroup
            // 
            this.buttonRemoveUserOfGroup.AutoSize = true;
            this.buttonRemoveUserOfGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRemoveUserOfGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveUserOfGroup.Location = new System.Drawing.Point(10, 58);
            this.buttonRemoveUserOfGroup.Name = "buttonRemoveUserOfGroup";
            this.buttonRemoveUserOfGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonRemoveUserOfGroup.TabIndex = 3;
            this.buttonRemoveUserOfGroup.Text = "Remove user";
            this.buttonRemoveUserOfGroup.UseVisualStyleBackColor = false;
            this.buttonRemoveUserOfGroup.Click += new System.EventHandler(this.buttonRemoveUserOfGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of group";
            // 
            // panelAddNewUser
            // 
            this.panelAddNewUser.Controls.Add(this.buttonAddNewUser);
            this.panelAddNewUser.Controls.Add(this.comboBoxAddNewUser);
            this.panelAddNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddNewUser.Location = new System.Drawing.Point(0, 134);
            this.panelAddNewUser.Name = "panelAddNewUser";
            this.panelAddNewUser.Size = new System.Drawing.Size(493, 40);
            this.panelAddNewUser.TabIndex = 8;
            this.panelAddNewUser.Visible = false;
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.AutoSize = true;
            this.buttonAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewUser.Location = new System.Drawing.Point(10, 9);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(99, 25);
            this.buttonAddNewUser.TabIndex = 3;
            this.buttonAddNewUser.Text = "Add user to";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // comboBoxAddNewUser
            // 
            this.comboBoxAddNewUser.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAddNewUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAddNewUser.FormattingEnabled = true;
            this.comboBoxAddNewUser.Location = new System.Drawing.Point(142, 10);
            this.comboBoxAddNewUser.Name = "comboBoxAddNewUser";
            this.comboBoxAddNewUser.Size = new System.Drawing.Size(341, 23);
            this.comboBoxAddNewUser.TabIndex = 0;
            // 
            // panelAddGroup
            // 
            this.panelAddGroup.Controls.Add(this.buttonCanselAddGroup);
            this.panelAddGroup.Controls.Add(this.buttonAddGroup);
            this.panelAddGroup.Controls.Add(this.textBoxbuttonlAddGroup);
            this.panelAddGroup.Controls.Add(this.label1);
            this.panelAddGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddGroup.Location = new System.Drawing.Point(0, 40);
            this.panelAddGroup.Name = "panelAddGroup";
            this.panelAddGroup.Size = new System.Drawing.Size(493, 94);
            this.panelAddGroup.TabIndex = 7;
            this.panelAddGroup.Visible = false;
            // 
            // buttonCanselAddGroup
            // 
            this.buttonCanselAddGroup.AutoSize = true;
            this.buttonCanselAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCanselAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanselAddGroup.Location = new System.Drawing.Point(384, 57);
            this.buttonCanselAddGroup.Name = "buttonCanselAddGroup";
            this.buttonCanselAddGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonCanselAddGroup.TabIndex = 3;
            this.buttonCanselAddGroup.Text = "Cansel";
            this.buttonCanselAddGroup.UseVisualStyleBackColor = false;
            this.buttonCanselAddGroup.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.AutoSize = true;
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddGroup.Enabled = false;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddGroup.Location = new System.Drawing.Point(142, 57);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonAddGroup.TabIndex = 2;
            this.buttonAddGroup.Text = "Add group";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // textBoxbuttonlAddGroup
            // 
            this.textBoxbuttonlAddGroup.Location = new System.Drawing.Point(142, 21);
            this.textBoxbuttonlAddGroup.Name = "textBoxbuttonlAddGroup";
            this.textBoxbuttonlAddGroup.Size = new System.Drawing.Size(341, 21);
            this.textBoxbuttonlAddGroup.TabIndex = 1;
            this.textBoxbuttonlAddGroup.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panelShowAllGroup
            // 
            this.panelShowAllGroup.Controls.Add(this.buttonRemoveGroup);
            this.panelShowAllGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowAllGroup.Location = new System.Drawing.Point(0, 0);
            this.panelShowAllGroup.Name = "panelShowAllGroup";
            this.panelShowAllGroup.Size = new System.Drawing.Size(493, 40);
            this.panelShowAllGroup.TabIndex = 6;
            this.panelShowAllGroup.Visible = false;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.AutoSize = true;
            this.buttonRemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRemoveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveGroup.Location = new System.Drawing.Point(10, 9);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(99, 25);
            this.buttonRemoveGroup.TabIndex = 1;
            this.buttonRemoveGroup.Text = "Remove group";
            this.buttonRemoveGroup.UseVisualStyleBackColor = false;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainerDG.Panel1.ResumeLayout(false);
            this.splitContainerDG.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDG)).EndInit();
            this.splitContainerDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelServerSettings.ResumeLayout(false);
            this.panelServerSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIC)).EndInit();
            this.panelFilterTest.ResumeLayout(false);
            this.panelFilterTest.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.panelTestFoGroup.ResumeLayout(false);
            this.panelTestFoGroup.PerformLayout();
            this.panelShowTests.ResumeLayout(false);
            this.panelShowTests.PerformLayout();
            this.panelShowAllUser.ResumeLayout(false);
            this.panelShowAllUser.PerformLayout();
            this.panelUpgradeGroup.ResumeLayout(false);
            this.panelUpgradeGroup.PerformLayout();
            this.panelAsignTest.ResumeLayout(false);
            this.panelAsignTest.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelLoadTest.ResumeLayout(false);
            this.panelLoadTest.PerformLayout();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.panelUpdateUser.ResumeLayout(false);
            this.panelUpdateUser.PerformLayout();
            this.panelShowUserOfGroup.ResumeLayout(false);
            this.panelShowUserOfGroup.PerformLayout();
            this.panelAddNewUser.ResumeLayout(false);
            this.panelAddNewUser.PerformLayout();
            this.panelAddGroup.ResumeLayout(false);
            this.panelAddGroup.PerformLayout();
            this.panelShowAllGroup.ResumeLayout(false);
            this.panelShowAllGroup.PerformLayout();
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
        private RepositoryLibrary.GenericUnitOfWork work;
        private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.User> repUs;
        private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.Group> repGr;
        private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.Test> repT;
        private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.Result> repR;
        //private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.Question> repQ;
        //private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.Answear> repAnsw;
        //private RepositoryLibrary.IGenericRepository<DALServerDB.Infrastructure.UserAnswear> repUsAnsw;

        public DALServerDB.Infrastructure.User User { get; }
        public string ConnectionStr { get; }

        private List<string> groupsStr = new List<string>() { "Show", "Add", "Update", "Add user", "Show users" };
        private List<string> usersStr = new List<string>() { "Show", "Add", "Update" };
        private List<string> testsStr = new List<string>() { "Load test", "Show all", "Assignes test", "Show test of groups" };
        private List<string> serverStr = new List<string>() { "Settings" };
        private List<string> resultStr = new List<string>() { "Show Result" };

        string symbSeparator = "/";
        string SelectedText = string.Empty;

        private string CurrentDocName { get; set; } = "test";
        private string Filter { get; set; } = "XML files (*.xml)|*.xml";

        private XmlClassLibrary.Test Test;

        private static TcpListener Listener;
        private DALServerDB.Infrastructure.Test ClientTest;
        private DALServerDB.Infrastructure.Result ClientResult;
        private CancellationTokenSource tokenSource = null;

        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(DALServerDB.Infrastructure.User user, string connection)
        {
            InitializeComponent();
            InitializeNewComponent();
            this.Text = "Server";
            Test = new XmlClassLibrary.Test();
            User = user;
            this.ConnectionStr = connection;
            int lineHeight = 15;
            int plusCount = 1;

            ConnectionDB();

            listBoxGroups.Items.AddRange(groupsStr.ToArray());
            listBoxUsers.Items.AddRange(usersStr.ToArray());
            listBoxTests.Items.AddRange(testsStr.ToArray());
            listBoxServer.Items.AddRange(serverStr.ToArray());
            listBoxResult.Items.AddRange(resultStr.ToArray());

            listBoxGroups.Size = NewListBoxSize(listBoxGroups.Width, listBoxGroups.Items.Count + plusCount, lineHeight);
            listBoxUsers.Size = NewListBoxSize(listBoxUsers.Width, listBoxUsers.Items.Count + plusCount, lineHeight);
            listBoxTests.Size = NewListBoxSize(listBoxTests.Width, listBoxTests.Items.Count + plusCount, lineHeight);
            listBoxServer.Size = NewListBoxSize(listBoxServer.Width, listBoxServer.Items.Count + plusCount, lineHeight);
            listBoxResult.Size = NewListBoxSize(listBoxResult.Width, listBoxResult.Items.Count + plusCount, lineHeight);

            labelSelected.Text = string.Empty;
            labelIsAdmin.Text = User.IsAdmin ? "Admin" : "User";
            labelFLName.Text = User.ToString();

            dataGridView1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
        }

        private void ConnectionDB()
        {
            work = new RepositoryLibrary.GenericUnitOfWork(new DALServerDB.ServerContext(ConnectionStr));

            repUs = work.Repository<DALServerDB.Infrastructure.User>();
            repGr = work.Repository<DALServerDB.Infrastructure.Group>();
            repT = work.Repository<DALServerDB.Infrastructure.Test>();
            repR = work.Repository<DALServerDB.Infrastructure.Result>();
            //repQ = work.Repository<DALServerDB.Infrastructure.Question>();
            //repAnsw = work.Repository<DALServerDB.Infrastructure.Answear>();
            //repUsAnsw = work.Repository<DALServerDB.Infrastructure.UserAnswear>();
        }
        private Size NewListBoxSize(int width, int lineQuantity, int lineHeight)
        {
            return new Size(width, lineQuantity * lineHeight);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Listener != null) Listener.Stop();
            if (e.CloseReason != CloseReason.FormOwnerClosing) this.Invoke(new Action(() => this.Owner.Close()));
        }

        #region Menu

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            ListBoxNotVisible();
            listBoxGroups.Visible = !listBoxGroups.Visible;
            LabelSelectedText(sender);
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            ListBoxNotVisible();
            listBoxUsers.Visible = !listBoxUsers.Visible;
            LabelSelectedText(sender);
        }
        private void buttonTests_Click(object sender, EventArgs e)
        {
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            ListBoxNotVisible();
            listBoxTests.Visible = !listBoxTests.Visible;
            LabelSelectedText(sender);
        }
        private void buttonServer_Click(object sender, EventArgs e)
        {
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            ListBoxNotVisible();
            listBoxServer.Visible = !listBoxServer.Visible;
            LabelSelectedText(sender);
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            ListBoxNotVisible();
            listBoxResult.Visible = !listBoxResult.Visible;
            LabelSelectedText(sender);
        }
        private void LabelSelectedText(object sender)
        {
            string tmp = string.Empty;
            if (listBoxGroups.Visible || listBoxUsers.Visible ||
                listBoxTests.Visible || listBoxServer.Visible ||
                listBoxResult.Visible)
                tmp = (sender as Button).Text;

            labelSelected.Text = tmp;
            SelectedText = tmp;
        }
        private void ListBoxNotVisible()
        {
            if (listBoxGroups.Visible) listBoxGroups.Visible = false;
            if (listBoxUsers.Visible) listBoxUsers.Visible = false;
            if (listBoxTests.Visible) listBoxTests.Visible = false;
            if (listBoxServer.Visible) listBoxServer.Visible = false;
            if (listBoxResult.Visible) listBoxResult.Visible = false;
        }

        private void PanelNotVisible()
        {
            if (panelShowAllGroup.Visible) panelShowAllGroup.Visible = false;
            if (panelAddGroup.Visible) panelAddGroup.Visible = false;
            if (panelUpgradeGroup.Visible) panelUpgradeGroup.Visible = false;
            if (panelAddNewUser.Visible) panelAddNewUser.Visible = false;
            if (panelShowUserOfGroup.Visible) panelShowUserOfGroup.Visible = false;

            if (panelShowAllUser.Visible) panelShowAllUser.Visible = false;
            if (panelAddUser.Visible) panelAddUser.Visible = false;
            if (panelUpdateUser.Visible) panelUpdateUser.Visible = false;

            if (panelLoadTest.Visible) panelLoadTest.Visible = false;
            if (panelShowTests.Visible) panelShowTests.Visible = false;
            if (panelAsignTest.Visible) panelAsignTest.Visible = false;
            if (panelTestFoGroup.Visible) panelTestFoGroup.Visible = false;
            if (panelFilterTest.Visible) panelFilterTest.Visible = false;

            if (panelServerSettings.Visible) panelServerSettings.Visible = false;

            if (panelFilterTest.Visible) panelFilterTest.Visible = false;
        }
        private void SplitContainerDGSplitterDistance(int height)
        {
            splitContainerDG.SplitterDistance = splitContainerDG.Height -
                height -
                splitContainerDG.SplitterWidth -
                splitContainerDG.Margin.Bottom -
                splitContainerDG.Margin.Top;
        }
        private void SplitContainerDGPanel1NotCollapsed()
        {
            if (splitContainerDG.Panel1Collapsed) splitContainerDG.Panel1Collapsed = false;
        }
        private void SplitContainerDGPanel1Collapsed()
        {
            if (!splitContainerDG.Panel1Collapsed) splitContainerDG.Panel1Collapsed = true;
        }
        private void AddTextToLabelSelectedText(ListBox listBox)
        {
            if (listBox == null) return;

            if (listBox.SelectedIndex != -1)
            {
                labelSelected.Text = SelectedText + symbSeparator + listBox.SelectedItem.ToString();
            }
        }

        #endregion Menu

        #region Group
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTextToLabelSelectedText(listBoxGroups);
            PanelNotVisible();
            SplitContainerDGPanel1NotCollapsed();

            switch (listBoxGroups.SelectedItem.ToString())
            {
                case "Show":
                    //dataGridView1.Columns[0].HeaderText = "название столбца";
                    //dataGridView1.TopLeftHeaderCell.Value = "Параметр";

                    SplitContainerDGSplitterDistance(panelShowAllGroup.Height);
                    panelShowAllGroup.Visible = true;
                    ShowGroup();
                    break;

                case "Add":
                    SplitContainerDGSplitterDistance(panelAddGroup.Height);
                    panelAddGroup.Visible = true;
                    ShowGroup();
                    break;

                case "Update":
                    SplitContainerDGSplitterDistance(panelUpgradeGroup.Height);
                    panelUpgradeGroup.Visible = true;
                    ShowGroup();
                    break;

                case "Add user":
                    SplitContainerDGSplitterDistance(panelAddNewUser.Height);
                    panelAddNewUser.Visible = true;
                    comboBoxAddNewUser.Items.Clear();
                    repGr.GetAll().ToList().ForEach(z => comboBoxAddNewUser.Items.Add(z.NameGroup));
                    if (comboBoxAddNewUser.Items.Count > 0) comboBoxAddNewUser.SelectedIndex = 0;
                    ShowAllUsers();
                    break;

                case "Show users":
                    SplitContainerDGSplitterDistance(panelShowUserOfGroup.Height);
                    panelShowUserOfGroup.Visible = true;
                    comboBoxShowUserOfGroup.Items.Clear();
                    repGr.GetAll().ToList().ForEach(z => comboBoxShowUserOfGroup.Items.Add(z.NameGroup));
                    if (comboBoxShowUserOfGroup.Items.Count > 0) comboBoxShowUserOfGroup.SelectedIndex = 0;
                    //ShowUsers();
                    break;
            }
        }

        private void ShowGroup()
        {
            dataGridView1.DataSource = repGr.GetDbSet().Select(x => new
            {
                Id = x.Id,
                Name = x.NameGroup,
                QtyOfUsers = x.Users.Count,
                QtyOfTests = x.Tests.Count
            }).ToList();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    // Category categoryTmp = cnt.Category.Where(c => c.Id == dataGridView1.SelectedRows[0].Index + 1).FirstOrDefault();
                    // Category categoryTmp = cnt.Category.Where(c => c.Id == dataGridView1.CurrentCell.RowIndex + 1).FirstOrDefault();
                    // Category categoryTmp = cnt.Category.Where(c => c.Id == dataGridView1.SelectedRows[0].Cells[0].Value).FirstOrDefault();
                    // Category categoryTmp = cnt.Categories.Where(c => c.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value)).FirstOrDefault();

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repGr.FindById(tmpId);
                    repGr.Remove(tmp);

                    //Category category = repositoryCategory.FindAll(x => x.Name == "Radio").FirstOrDefault();
                    ShowGroup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Выделите необходимое", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxbuttonlAddGroup.Text))
            {
                if (listBoxGroups.Visible)
                {
                    if (IsGroupNameContains(textBoxbuttonlAddGroup.Text))
                    {
                        MessageBox.Show("Group name exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    repGr.Add(new DALServerDB.Infrastructure.Group() { NameGroup = textBoxbuttonlAddGroup.Text });
                    ShowGroup();
                }
                textBoxbuttonlAddGroup.Text = string.Empty;
            }
        }
        private bool IsGroupNameContains(string NameGroup)
        {
            return repGr.FindAll(x => x.NameGroup == NameGroup).FirstOrDefault() != null;
        }
        private void buttonCansel_Click(object sender, EventArgs e)
        {
            textBoxbuttonlAddGroup.Text = string.Empty;
            textBoxUpgradeGroup.Text = string.Empty;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxbuttonlAddGroup.Text)) buttonAddGroup.Enabled = false;
            else buttonAddGroup.Enabled = true;
            if (string.IsNullOrWhiteSpace(textBoxUpgradeGroup.Text)) buttonlUpgradeGroup.Enabled = false;
            else buttonlUpgradeGroup.Enabled = true;
        }
        private void buttonlUpgradeGroup_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repGr.FindById(tmpId);

                    if (tmp.NameGroup == textBoxUpgradeGroup.Text) return;

                    tmp.NameGroup = textBoxUpgradeGroup.Text;
                    repGr.Update(tmp);

                    ShowGroup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;
                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    if (panelUpgradeGroup.Visible)
                    {
                        var tmp = repGr.FindById(tmpId);
                        textBoxUpgradeGroup.Text = tmp?.NameGroup;
                    }
                    if (panelUpdateUser.Visible)
                    {
                        var tmp = repUs.FindById(tmpId);
                        textBoxFN.Text = tmp?.FirstName;
                        textBoxLN.Text = tmp?.LastName;
                        checkBoxIsAdmin.Checked = tmp.IsAdmin;
                        textBoxLogin.Text = tmp?.Login;
                        textBoxPassword.Text = DALServerDB.Models.Crypter.GetCrypt(tmp?.Password);
                        textBoxConfPass.Text = textBoxPassword.Text;
                    }
                }
                catch { }
            }
        }

        #region User
        private void ShowAllUsers()
        {
            dataGridView1.DataSource = repUs.GetAll();
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Groups"].Visible = false;
        }
        private void ShowGroupUsers()
        {
            //var tmp1 = cnt.Students.Where(z => (z.FirstName + " " + z.LastName) == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            //Category category = repositoryCategory.FindAll(x => x.Name == "Radio").FirstOrDefault();
            dataGridView1.DataSource = repUs.FindAll(x => x.Groups.Any(z => z.NameGroup == comboBoxShowUserOfGroup.SelectedItem.ToString())).ToList();
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Groups"].Visible = false;
        }
        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (comboBoxAddNewUser.Items.Count > 0 &&
                comboBoxAddNewUser.SelectedIndex != -1 &&
                dataGridView1.SelectedRows.Count > 0)
            {
                int tmpId;
                tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var tmp = repUs.FindById(tmpId);
                var nameGroup = comboBoxAddNewUser.SelectedItem.ToString();

                if (tmp.Groups.FirstOrDefault(x => x.NameGroup == nameGroup) != null) return;

                var group = repGr.FindAll(x => x.NameGroup == nameGroup).FirstOrDefault();
                if (group == null) return;

                tmp.Groups.Add(group);
                repUs.Update(tmp);
            }
        }
        private void comboBoxShowUserOfGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGroupUsers();
        }
        private void buttonRemoveUserOfGroup_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repUs.FindById(tmpId);
                    var nameGroup = comboBoxAddNewUser.SelectedItem.ToString();
                    var group = tmp.Groups.FirstOrDefault(x => x.NameGroup == nameGroup);
                    if (group != null) tmp.Groups.Remove(group);
                    repUs.Update(tmp);

                    ShowGroupUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Выделите необходимое", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        #endregion User

        #endregion Group

        #region Users
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTextToLabelSelectedText(listBoxUsers);
            PanelNotVisible();
            SplitContainerDGPanel1NotCollapsed();
            switch (listBoxUsers.SelectedItem.ToString())
            {
                case "Show":
                    SplitContainerDGSplitterDistance(panelShowAllUser.Height);
                    panelShowAllUser.Visible = true;
                    break;

                case "Add":
                    SplitContainerDGSplitterDistance(panelAddUser.Height);
                    panelAddUser.Visible = true;
                    break;

                case "Update":
                    SplitContainerDGSplitterDistance(panelUpdateUser.Height);
                    panelUpdateUser.Visible = true;
                    break;
            }
            ShowAllUsersWithPassword();
        }

        private void ShowAllUsersWithPassword()
        {
            dataGridView1.DataSource = repUs.GetAll();
            dataGridView1.Columns["Password"].Visible = true;
            dataGridView1.Columns["Groups"].Visible = false;
        }
        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repUs.FindById(tmpId);
                    repUs.Remove(tmp);

                    ShowAllUsersWithPassword();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Выделите необходимое", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        private bool IsLoginContains(string Login)
        {
            return repUs.FindAll(x => x.Login == Login).FirstOrDefault() != null;
        }
        private void buttonOkAddUser_Click(object sender, EventArgs e)
        {
            if (!textBoxPasswAddUser.Text.Equals(textBoxConfPaswAddUser.Text))
            {
                MessageBox.Show("Password != Confirm password", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (IsLoginContains(textBoxLoginAddUser.Text))
            {
                MessageBox.Show("Login exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repUs.Add(new DALServerDB.Infrastructure.User()
            {
                FirstName = textBoxFNAddUser.Text,
                LastName = textBoxLNAddUser.Text,
                IsAdmin = checkBoxIsAdminAddUser.Checked,
                Login = textBoxLoginAddUser.Text,
                Password = DALServerDB.Models.Crypter.SetCrypt(textBoxPasswAddUser.Text)
            });
            CleanTextBox();
            ShowAllUsersWithPassword();
        }
        private void buttonCanselAddUser_Click(object sender, EventArgs e)
        {
            CleanTextBox();
        }
        private void CleanTextBox()
        {
            textBoxFNAddUser.Text = string.Empty;
            textBoxLNAddUser.Text = string.Empty;
            textBoxLoginAddUser.Text = string.Empty;
            textBoxPasswAddUser.Text = string.Empty;
            textBoxConfPaswAddUser.Text = string.Empty;
            checkBoxIsAdminAddUser.Checked = false;

            textBoxFN.Text = string.Empty;
            textBoxLN.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfPass.Text = string.Empty;
            checkBoxIsAdmin.Checked = false;
        }
        private void textBoxFNAddUser_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFNAddUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxLNAddUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxLoginAddUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxPasswAddUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfPaswAddUser.Text))
                buttonOkAddUser.Enabled = false;
            else buttonOkAddUser.Enabled = true;
        }
        private void buttonOkUpdateUser_Click(object sender, EventArgs e)
        {
            if (!textBoxPassword.Text.Equals(textBoxConfPass.Text))
            {
                MessageBox.Show("Password != Confirm password", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int tmpId;

            tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var tmp = repUs.FindById(tmpId);

            if (tmp.Login != textBoxLogin.Text && IsLoginContains(textBoxLogin.Text))
            {
                MessageBox.Show("Login exist", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tmp.FirstName == textBoxFN.Text &&
                tmp.LastName == textBoxLN.Text &&
                tmp.Login == textBoxLogin.Text &&
                tmp.Password == textBoxPassword.Text &&
                tmp.IsAdmin == checkBoxIsAdmin.Checked) return;

            tmp.FirstName = textBoxFN.Text;
            tmp.LastName = textBoxLN.Text;
            tmp.Login = textBoxLogin.Text;
            tmp.Password = DALServerDB.Models.Crypter.SetCrypt(textBoxPassword.Text);
            tmp.IsAdmin = checkBoxIsAdmin.Checked;
            repUs.Update(tmp);
            CleanTextBox();
            ShowAllUsersWithPassword();
        }
        private void buttonCanselUpdateUser_Click(object sender, EventArgs e)
        {
            CleanTextBox();
        }
        private void textBoxFN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFN.Text) ||
                string.IsNullOrWhiteSpace(textBoxLN.Text) ||
                string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfPass.Text))
                buttonOkUpdateUser.Enabled = false;
            else buttonOkUpdateUser.Enabled = true;
        }
        #endregion Users

        #region Tests
        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTextToLabelSelectedText(listBoxTests);
            PanelNotVisible();
            SplitContainerDGPanel1NotCollapsed();
            switch (listBoxTests.SelectedItem.ToString())
            {
                case "Load test":
                    SplitContainerDGPanel1Collapsed();
                    panelLoadTest.Visible = true;
                    break;

                case "Show all":
                    SplitContainerDGSplitterDistance(panelShowTests.Height);
                    panelShowTests.Visible = true;
                    ShowAllTests();
                    break;

                case "Assignes test":
                    SplitContainerDGSplitterDistance(panelAsignTest.Height);
                    panelAsignTest.Visible = true;
                    comboBox3.Items.Clear();
                    repGr.GetAll().ToList().ForEach(z => comboBox3.Items.Add(z.NameGroup));
                    if (comboBox3.Items.Count > 0) comboBox3.SelectedIndex = 0;
                    ShowAllTests();
                    break;

                case "Show test of groups":
                    SplitContainerDGSplitterDistance(panelTestFoGroup.Height);
                    panelTestFoGroup.Visible = true;
                    comboBoxTestFoGroup.Items.Clear();
                    repGr.GetAll().ToList().ForEach(z => comboBoxTestFoGroup.Items.Add(z.NameGroup));
                    if (comboBoxTestFoGroup.Items.Count > 0) comboBoxTestFoGroup.SelectedIndex = 0;
                    break;
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = Filter;
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Test = new XmlClassLibrary.Test();
                    CurrentDocName = openFileDialog1.FileName;
                    XmlSerializer serializer = new XmlSerializer(Test.GetType());
                    using (FileStream fs = new FileStream(CurrentDocName, FileMode.OpenOrCreate))
                    {

                        Test = (XmlClassLibrary.Test)serializer.Deserialize(fs);
                        textBoxAuthor.Text = Test.Author;
                        textBoxNameT.Text = Test.TestName;
                        textBoxQtyOfQues.Text = Test.Qty_questions;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonOkLoadTest_Click(object sender, EventArgs e)
        {
            DALServerDB.Infrastructure.Test test = new DALServerDB.Infrastructure.Test()
            {
                Author = textBoxAuthor.Text,
                Title = textBoxNameT.Text,
                Time = new TimeSpan((int)numericUpDownHour.Value,
                 (int)numericUpDownMinute.Value, 0)
            };

            foreach (var question in Test.Question)
            {
                DALServerDB.Infrastructure.Question tmpQuestion = new DALServerDB.Infrastructure.Question()
                {
                    Title = question.Description,
                    Difficulty = Convert.ToInt32(question.Difficulty)
                };
                foreach (var answer in question.Answer)
                {
                    tmpQuestion.Answears.Add(new DALServerDB.Infrastructure.Answear()
                    {
                        Description = answer.Description,
                        IsRight = Convert.ToBoolean(answer.IsRight)
                    });
                }
                test.Questions.Add(tmpQuestion);
            }

            repT.Add(test);
            CleanPanelLoadTest();
            Test = null;
        }
        private void buttonCanselLoadTest_Click(object sender, EventArgs e)
        {
            Test = null;
            CleanPanelLoadTest();
        }
        private void CleanPanelLoadTest()
        {
            textBoxAuthor.Text = string.Empty;
            textBoxNameT.Text = string.Empty;
            textBoxQtyOfQues.Text = string.Empty;
            numericUpDownHour.Value = 0;
            numericUpDownMinute.Value = 0;
        }
        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                string.IsNullOrWhiteSpace(textBoxNameT.Text) ||
                string.IsNullOrWhiteSpace(textBoxQtyOfQues.Text))
                buttonOkLoadTest.Enabled = false;
            else buttonOkLoadTest.Enabled = true;
        }

        #region Show / Add tests
        private void ShowAllTests()
        {
            dataGridView1.DataSource = repT.GetAll();
            dataGridView1.Columns["Questions"].Visible = false;
            dataGridView1.Columns["Groups"].Visible = false;
        }
        private void buttonRemoveTest_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repT.FindById(tmpId);
                    repT.Remove(tmp);

                    ShowAllTests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Выделите необходимое", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            if (comboBox3.Items.Count > 0 &&
                comboBox3.SelectedIndex != -1 &&
                dataGridView1.SelectedRows.Count > 0)
            {
                int tmpId;
                tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var tmp = repT.FindById(tmpId);
                var nameGroup = comboBox3.SelectedItem.ToString();

                if (tmp.Groups.FirstOrDefault(x => x.NameGroup == nameGroup) != null) return;

                var group = repGr.FindAll(x => x.NameGroup == nameGroup).FirstOrDefault();
                if (group == null) return;

                tmp.Groups.Add(group);
                repT.Update(tmp);

                ShowTestOfGroup();
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTestOfGroup();
        }
        private void ShowTestOfGroup()
        {
            dataGridView2.DataSource = repT.FindAll(x => x.Groups.Any(z => z.NameGroup == comboBox3.SelectedItem.ToString())).ToList();
            dataGridView2.Columns["Questions"].Visible = false;
            dataGridView2.Columns["Groups"].Visible = false;
        }

        private void buttonRemoveTestFoGroup_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int tmpId;

                    tmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var tmp = repT.FindById(tmpId);
                    var nameGroup = comboBoxTestFoGroup.SelectedItem.ToString();
                    var group = tmp.Groups.FirstOrDefault(x => x.NameGroup == nameGroup);
                    if (group != null) tmp.Groups.Remove(group);
                    repT.Update(tmp);

                    ShowGroupTests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Выделите необходимое", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
        private void ShowGroupTests()
        {
            dataGridView1.DataSource = repT.FindAll(x => x.Groups.Any(z => z.NameGroup == comboBoxTestFoGroup.SelectedItem.ToString())).ToList();
        }
        private void comboBoxTestFoGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGroupTests();
        }
        #endregion Show / Add tests

        #endregion Tests

        #region Server
        private void listBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTextToLabelSelectedText(listBoxServer);
            PanelNotVisible();
            SplitContainerDGPanel1Collapsed();
            switch (listBoxServer.SelectedItem.ToString())
            {
                case "Settings":
                    panelServerSettings.Visible = true;
                    ButtonStartServerEnabled();
                    if (Listener != null) buttonStart.Enabled = false;
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxHostName.Enabled = false;
            textBoxPortNumber.Enabled = false;
            buttonStart.Enabled = false;
            if (Listener == null)
            {
                try
                {
                    IPAddress localAddr = IPAddress.Parse(textBoxHostName.Text);
                    int port = int.Parse(textBoxPortNumber.Text);

                    Listener = new TcpListener(localAddr, port);
                    tokenSource = new CancellationTokenSource();
                    Task.Factory.StartNew(() => ListenThread(Listener, tokenSource.Token), tokenSource.Token);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
        private void ListenThread(TcpListener listener, CancellationToken token)
        {
            Listener.Start(2);

            while (true)
            {
                try
                {
                    if (tokenSource.Token.IsCancellationRequested) tokenSource.Token.ThrowIfCancellationRequested();

                    TcpClient client = Listener.AcceptTcpClient();

                    //// создаем новый поток для обслуживания нового клиента
                    //Thread clientThread = new Thread(Process);
                    //clientThread.Start(client);

                    Task.Factory.StartNew(() => Process(client, tokenSource.Token), tokenSource.Token);
                }
                catch /*(Exception ex)*/ { break; /*MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); break;*/ }
            }
        }
        private void Process(object sender, CancellationToken token)
        {
            TcpClient client = sender as TcpClient;
            NetworkStream stream = null;
            try
            {
                using (stream = client.GetStream())
                {
                    DALServerDB.Data obj = null;

                    while (true)
                    {
                        if (tokenSource == null) return;
                        if (tokenSource.Token.IsCancellationRequested) tokenSource.Token.ThrowIfCancellationRequested();
                        obj = (DALServerDB.Data)new BinaryFormatter().Deserialize(stream);
                        if (obj?.Token == null) obj = CheckUser(obj);
                        else if (!obj.IsWorking) return;
                        else if (obj.IsGroup)
                        {
                            obj.Tests = GetTest(obj.Group);
                            obj.IsGroup = false;
                        }
                        else if (obj.IsTest)
                        {
                            ClientTest = repT.FindById(obj.TestId);
                            obj.IsTest = false;
                        }
                        else
                        {
                            if (obj.IsStart)
                            {
                                obj.QuestionQty = ClientTest.Questions.Count;
                                //obj.IsStart = false;
                                obj.QuestionId = ClientTest.Questions.Min(x => x.Id);

                                ClientResult = repR.FindAll(x => x.User.Id == obj.UserId && x.Test.Id == obj.TestId).LastOrDefault();
                                if (ClientResult != null)
                                {
                                    ClientResult.Date = DateTime.Today;
                                    ClientResult.Mark = 0;
                                    ClientResult.QtyOfRightAnswers = 0;
                                    repR.Update(ClientResult);
                                }
                                else
                                {
                                    ClientResult = new DALServerDB.Infrastructure.Result()
                                    {
                                        Date = DateTime.Now,
                                        Mark = 0,
                                        QtyOfRightAnswers = 0,
                                        Test = repT.FindById(obj.TestId),
                                        User = repUs.FindById(obj.UserId)
                                    };
                                    repR.Add(ClientResult);
                                }
                            }
                            else if (!obj.IsStart) // count mark
                            {
                                var a = ClientTest.Questions.FirstOrDefault(x => x.Id == (int)obj.QuestionId).Answears.FirstOrDefault(x => x.IsRight);
                                if (obj.AnswearId != null && a.Id == obj.AnswearId)
                                {
                                    ClientResult.QtyOfRightAnswers++;
                                    repR.Update(ClientResult);
                                }
                            }

                            if (obj.IsPassing && !obj.IsLast && !obj.IsStart) // next Question
                            {
                                obj.QuestionId = ClientTest.Questions.Select(x => x.Id).OrderBy(x => x).FirstOrDefault(x => x > obj.QuestionId);
                            }

                            if (obj.IsPassing && !obj.IsLast) // GetQuestion and GetAnswears
                            {
                                int questionId = (int)obj.QuestionId;
                                obj.Question = GetQuestion(ClientTest, questionId);
                                obj.Answears = GetAnswears(ClientTest, questionId);
                            }

                            if (obj.IsLast)
                            {
                                if (ClientResult != null)
                                {
                                    ClientResult.Mark = GetMarkForTest(ClientResult.QtyOfRightAnswers, obj.QuestionQty);
                                    ClientResult.Date = DateTime.Now;
                                    ClientResult.Test = repT.FindById(obj.TestId);
                                    ClientResult.User = repUs.FindById(obj.UserId);
                                    repR.Update(ClientResult);
                                    obj.ResultMark = ClientResult.Mark;
                                    obj.QtyOfRightAnswers = ClientResult.QtyOfRightAnswers;
                                }
                                ClientResult = null;
                                ClientTest = null;
                                obj.IsLast = false;
                                obj.IsPassing = false;
                            }
                        }

                        //do smth
                        if (obj == null)
                        {
                            obj = new DALServerDB.Data() { Token = null };
                        }

                        new BinaryFormatter().Serialize(client.GetStream(), obj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (stream != null) stream.Close();
                if (client != null) client.Close();
            }
        }
        private List<DALServerDB.TestForData> GetTest(string group)
        {
            List<DALServerDB.TestForData> tmp = new List<DALServerDB.TestForData>();
            repT.FindAll(x => x.Groups.Any(z => z.NameGroup == group)).ToList().
                ForEach(x => tmp.Add(new DALServerDB.TestForData()
                {
                    Id = x.Id,
                    Author = x.Author,
                    Title = x.Title,
                    Time = x.Time
                }));
            return tmp;
        }
        private int GetMarkForTest(int qtyOfRightAnswers, int questionQty)
        {
            int a = qtyOfRightAnswers * 100 / questionQty;
            int mark = 0;
            if (a < 20) mark = 2;
            else if (a >= 20 && a < 40) mark = 4;
            else if (a >= 40 && a < 60) mark = 6;
            else if (a >= 60 && a < 80) mark = 8;
            else if (a >= 80 && a <= 100) mark = 10;
            return mark;
        }
        private List<DALServerDB.AnswearForData> GetAnswears(DALServerDB.Infrastructure.Test test, int questionId)
        {
            List<DALServerDB.AnswearForData> tmp = new List<DALServerDB.AnswearForData>();

            test.Questions.FirstOrDefault(x => x.Id == questionId).Answears.ToList().ForEach(q => tmp.Add(new DALServerDB.AnswearForData()
            {
                Id = q.Id,
                Description = q.Description
            }));
            return tmp;
        }
        private string GetQuestion(DALServerDB.Infrastructure.Test test, int questionId)
        {
            return test.Questions.FirstOrDefault(x => x.Id == questionId).Title;
        }
        private DALServerDB.Data CheckUser(DALServerDB.Data data)
        {
            if (data == null) return null;
            var user1 = repUs.FindAll(p => p.Login == data.Login);
            if (user1 == null) return null;
            var User = user1.FirstOrDefault(x => DALServerDB.Models.Crypter.GetCrypt(x.Password) == data.Password);
            if (User != null)
            {
                data.Token = User.FirstName + User.LastName;
                data.FName = User.FirstName;
                data.LName = User.LastName;
                data.UserId = User.Id;
                data.Password = string.Empty;
                data.Login = string.Empty;
                data.Groups = new List<string>();
                User.Groups.ToList().ForEach(x => data.Groups.Add(x.NameGroup));
                data.IsWorking = true;
                data.IsGroup = false;
                data.IsTest = false;
                data.IsPassing = false;
                data.IsStart = false;
                data.IsLast = false;

                return data;
            }
            return null;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            if (Listener != null) Listener.Stop();
            Listener = null;
            tokenSource = null;
            textBoxHostName.Enabled = true;
            textBoxPortNumber.Enabled = true;
            buttonStart.Enabled = true;
        }
        private void textBoxHostName_TextChanged(object sender, EventArgs e)
        {
            ButtonStartServerEnabled();
        }
        private void ButtonStartServerEnabled()
        {
            if (string.IsNullOrWhiteSpace(textBoxHostName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPortNumber.Text))
                buttonStart.Enabled = false;
            else buttonStart.Enabled = true;
        }

        #endregion Server

        #region Result
        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTextToLabelSelectedText(listBoxResult);
            PanelNotVisible();
            SplitContainerDGPanel1NotCollapsed();
            switch (listBoxResult.SelectedItem.ToString())
            {
                case "Show Result":
                    SplitContainerDGSplitterDistance(0);

                    //SplitContainerDGSplitterDistance(panelFilterTest.Height);
                    //panelFilterTest.Visible = true;
                    //comboBoxTestTitle.Items.Clear();
                    //comboBoxTestTitle.Items.Add("All");
                    //repT.GetAll().ToList().ForEach(z => comboBoxTestTitle.Items.Add(z.Title));
                    //if (comboBoxTestTitle.Items.Count > 0) comboBoxTestTitle.SelectedIndex = 0;

                    ShowResult();
                    break;
            }
        }

        private void ShowResult()
        {
            dataGridView1.DataSource = repR.GetDbSet().Select(x => new
            {
                Id = x.Id,
                Date = x.Date,
                Name = x.User.FirstName,
                LastName = x.User.LastName,
                Test = x.Test.Title,
                QtyOfRightAnswers = x.QtyOfRightAnswers,
                Mark = x.Mark
            }).ToList();
        }
        private void comboBoxTestTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTestTitle.SelectedItem.ToString() == "All")
                ShowResult();
            else
            {
                dataGridView1.DataSource = repR.FindAll(x => x.Test.Title ==
                comboBoxTestTitle.SelectedItem.ToString()).
                Select(x => new
                {
                    Id = x.Id,
                    Date = x.Date,
                    FirstName = x?.User?.FirstName,
                    LastName = x?.User?.LastName,
                    Test = x?.Test?.Title,
                    QtyOfRightAnswers = x.QtyOfRightAnswers,
                    Mark = x.Mark,
                }).
                ToList();

                //(dataGridView1.DataSource as DataTable).
                //    DefaultView.RowFilter = string.Format("Test = '{0}'", comboBoxTestTitle.SelectedItem.ToString());
            }
        }

        #endregion Result
    }
}
