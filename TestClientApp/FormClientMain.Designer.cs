
namespace TestClientApp
{
    partial class FormClientMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainerFullScreen = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftP = new System.Windows.Forms.SplitContainer();
            this.labelFLName = new System.Windows.Forms.Label();
            this.comboBoxGroupName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainerRightP = new System.Windows.Forms.SplitContainer();
            this.labelSelected = new System.Windows.Forms.Label();
            this.splitContainerDG = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPassTests = new System.Windows.Forms.Panel();
            this.buttonPassTest = new System.Windows.Forms.Button();
            this.panelTest = new System.Windows.Forms.Panel();
            this.panelForPanelTest = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.splitContainerAnsBut = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelSpanTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelQuestionCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFullScreen)).BeginInit();
            this.splitContainerFullScreen.Panel1.SuspendLayout();
            this.splitContainerFullScreen.Panel2.SuspendLayout();
            this.splitContainerFullScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftP)).BeginInit();
            this.splitContainerLeftP.Panel1.SuspendLayout();
            this.splitContainerLeftP.Panel2.SuspendLayout();
            this.splitContainerLeftP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightP)).BeginInit();
            this.splitContainerRightP.Panel1.SuspendLayout();
            this.splitContainerRightP.Panel2.SuspendLayout();
            this.splitContainerRightP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDG)).BeginInit();
            this.splitContainerDG.Panel1.SuspendLayout();
            this.splitContainerDG.Panel2.SuspendLayout();
            this.splitContainerDG.SuspendLayout();
            this.panelPassTests.SuspendLayout();
            this.panelTest.SuspendLayout();
            this.panelForPanelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnsBut)).BeginInit();
            this.splitContainerAnsBut.Panel1.SuspendLayout();
            this.splitContainerAnsBut.Panel2.SuspendLayout();
            this.splitContainerAnsBut.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainerFullScreen
            // 
            this.splitContainerFullScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFullScreen.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFullScreen.ForeColor = System.Drawing.Color.White;
            this.splitContainerFullScreen.IsSplitterFixed = true;
            this.splitContainerFullScreen.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFullScreen.Name = "splitContainerFullScreen";
            // 
            // splitContainerFullScreen.Panel1
            // 
            this.splitContainerFullScreen.Panel1.Controls.Add(this.splitContainerLeftP);
            // 
            // splitContainerFullScreen.Panel2
            // 
            this.splitContainerFullScreen.Panel2.Controls.Add(this.splitContainerRightP);
            this.splitContainerFullScreen.Size = new System.Drawing.Size(784, 539);
            this.splitContainerFullScreen.SplitterDistance = 268;
            this.splitContainerFullScreen.TabIndex = 2;
            this.splitContainerFullScreen.TabStop = false;
            // 
            // splitContainerLeftP
            // 
            this.splitContainerLeftP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.splitContainerLeftP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftP.IsSplitterFixed = true;
            this.splitContainerLeftP.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftP.Name = "splitContainerLeftP";
            this.splitContainerLeftP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeftP.Panel1
            // 
            this.splitContainerLeftP.Panel1.Controls.Add(this.labelFLName);
            // 
            // splitContainerLeftP.Panel2
            // 
            this.splitContainerLeftP.Panel2.Controls.Add(this.comboBoxGroupName);
            this.splitContainerLeftP.Panel2.Controls.Add(this.label2);
            this.splitContainerLeftP.Size = new System.Drawing.Size(268, 539);
            this.splitContainerLeftP.SplitterDistance = 67;
            this.splitContainerLeftP.SplitterWidth = 10;
            this.splitContainerLeftP.TabIndex = 1;
            this.splitContainerLeftP.TabStop = false;
            // 
            // labelFLName
            // 
            this.labelFLName.AutoSize = true;
            this.labelFLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFLName.ForeColor = System.Drawing.Color.Aqua;
            this.labelFLName.Location = new System.Drawing.Point(12, 9);
            this.labelFLName.Name = "labelFLName";
            this.labelFLName.Size = new System.Drawing.Size(139, 25);
            this.labelFLName.TabIndex = 2;
            this.labelFLName.Text = "labelFLName";
            // 
            // comboBoxGroupName
            // 
            this.comboBoxGroupName.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGroupName.FormattingEnabled = true;
            this.comboBoxGroupName.Location = new System.Drawing.Point(14, 32);
            this.comboBoxGroupName.Name = "comboBoxGroupName";
            this.comboBoxGroupName.Size = new System.Drawing.Size(235, 23);
            this.comboBoxGroupName.TabIndex = 6;
            this.comboBoxGroupName.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of group";
            // 
            // splitContainerRightP
            // 
            this.splitContainerRightP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.splitContainerRightP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRightP.IsSplitterFixed = true;
            this.splitContainerRightP.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightP.Name = "splitContainerRightP";
            this.splitContainerRightP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightP.Panel1
            // 
            this.splitContainerRightP.Panel1.Controls.Add(this.labelSelected);
            // 
            // splitContainerRightP.Panel2
            // 
            this.splitContainerRightP.Panel2.Controls.Add(this.splitContainerDG);
            this.splitContainerRightP.Size = new System.Drawing.Size(512, 539);
            this.splitContainerRightP.SplitterDistance = 67;
            this.splitContainerRightP.SplitterWidth = 10;
            this.splitContainerRightP.TabIndex = 3;
            this.splitContainerRightP.TabStop = false;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelected.ForeColor = System.Drawing.Color.Aqua;
            this.labelSelected.Location = new System.Drawing.Point(3, 9);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(96, 25);
            this.labelSelected.TabIndex = 2;
            this.labelSelected.Text = "Selected";
            // 
            // splitContainerDG
            // 
            this.splitContainerDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.splitContainerDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDG.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerDG.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDG.Name = "splitContainerDG";
            this.splitContainerDG.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDG.Panel1
            // 
            this.splitContainerDG.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainerDG.Panel2
            // 
            this.splitContainerDG.Panel2.AutoScroll = true;
            this.splitContainerDG.Panel2.Controls.Add(this.panelPassTests);
            this.splitContainerDG.Size = new System.Drawing.Size(512, 462);
            this.splitContainerDG.SplitterDistance = 384;
            this.splitContainerDG.SplitterWidth = 8;
            this.splitContainerDG.TabIndex = 0;
            this.splitContainerDG.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnTitle,
            this.columnAuthor,
            this.columnTime});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 382);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnAuthor
            // 
            this.columnAuthor.Text = "Author";
            this.columnAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelPassTests
            // 
            this.panelPassTests.Controls.Add(this.buttonPassTest);
            this.panelPassTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassTests.Location = new System.Drawing.Point(0, 0);
            this.panelPassTests.Name = "panelPassTests";
            this.panelPassTests.Size = new System.Drawing.Size(510, 40);
            this.panelPassTests.TabIndex = 17;
            // 
            // buttonPassTest
            // 
            this.buttonPassTest.AutoSize = true;
            this.buttonPassTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonPassTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPassTest.Location = new System.Drawing.Point(10, 9);
            this.buttonPassTest.Name = "buttonPassTest";
            this.buttonPassTest.Size = new System.Drawing.Size(99, 25);
            this.buttonPassTest.TabIndex = 1;
            this.buttonPassTest.Text = "Pass the test";
            this.buttonPassTest.UseVisualStyleBackColor = false;
            this.buttonPassTest.Click += new System.EventHandler(this.buttonPassTest_Click);
            // 
            // panelTest
            // 
            this.panelTest.BackColor = System.Drawing.SystemColors.Info;
            this.panelTest.Controls.Add(this.panelForPanelTest);
            this.panelTest.Controls.Add(this.labelSpanTime);
            this.panelTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTest.Location = new System.Drawing.Point(0, 0);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(784, 539);
            this.panelTest.TabIndex = 4;
            this.panelTest.Visible = false;
            // 
            // panelForPanelTest
            // 
            this.panelForPanelTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForPanelTest.Controls.Add(this.splitContainer1);
            this.panelForPanelTest.Location = new System.Drawing.Point(3, 32);
            this.panelForPanelTest.Name = "panelForPanelTest";
            this.panelForPanelTest.Size = new System.Drawing.Size(778, 504);
            this.panelForPanelTest.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerAnsBut);
            this.splitContainer1.Size = new System.Drawing.Size(778, 504);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxQuestion);
            this.groupBox1.Controls.Add(this.labelQuestionCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Location = new System.Drawing.Point(3, 17);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQuestion.Size = new System.Drawing.Size(770, 173);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // splitContainerAnsBut
            // 
            this.splitContainerAnsBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAnsBut.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerAnsBut.IsSplitterFixed = true;
            this.splitContainerAnsBut.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAnsBut.Name = "splitContainerAnsBut";
            this.splitContainerAnsBut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAnsBut.Panel1
            // 
            this.splitContainerAnsBut.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainerAnsBut.Panel2
            // 
            this.splitContainerAnsBut.Panel2.Controls.Add(this.buttonStart);
            this.splitContainerAnsBut.Panel2.Controls.Add(this.buttonNext);
            this.splitContainerAnsBut.Size = new System.Drawing.Size(776, 297);
            this.splitContainerAnsBut.SplitterDistance = 264;
            this.splitContainerAnsBut.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answears";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(770, 244);
            this.checkedListBox1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(3, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(698, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelSpanTime
            // 
            this.labelSpanTime.AutoSize = true;
            this.labelSpanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpanTime.Location = new System.Drawing.Point(12, 9);
            this.labelSpanTime.Name = "labelSpanTime";
            this.labelSpanTime.Size = new System.Drawing.Size(145, 20);
            this.labelSpanTime.TabIndex = 1;
            this.labelSpanTime.Text = "00:00:00 / 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionCount.Location = new System.Drawing.Point(75, -1);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(39, 20);
            this.labelQuestionCount.TabIndex = 5;
            this.labelQuestionCount.Text = "0 / 0";
            // 
            // FormClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.splitContainerFullScreen);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientMain_FormClosing);
            this.splitContainerFullScreen.Panel1.ResumeLayout(false);
            this.splitContainerFullScreen.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFullScreen)).EndInit();
            this.splitContainerFullScreen.ResumeLayout(false);
            this.splitContainerLeftP.Panel1.ResumeLayout(false);
            this.splitContainerLeftP.Panel1.PerformLayout();
            this.splitContainerLeftP.Panel2.ResumeLayout(false);
            this.splitContainerLeftP.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftP)).EndInit();
            this.splitContainerLeftP.ResumeLayout(false);
            this.splitContainerRightP.Panel1.ResumeLayout(false);
            this.splitContainerRightP.Panel1.PerformLayout();
            this.splitContainerRightP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightP)).EndInit();
            this.splitContainerRightP.ResumeLayout(false);
            this.splitContainerDG.Panel1.ResumeLayout(false);
            this.splitContainerDG.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDG)).EndInit();
            this.splitContainerDG.ResumeLayout(false);
            this.panelPassTests.ResumeLayout(false);
            this.panelPassTests.PerformLayout();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.panelForPanelTest.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainerAnsBut.Panel1.ResumeLayout(false);
            this.splitContainerAnsBut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAnsBut)).EndInit();
            this.splitContainerAnsBut.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerFullScreen;
        private System.Windows.Forms.SplitContainer splitContainerLeftP;
        private System.Windows.Forms.Label labelFLName;
        private System.Windows.Forms.SplitContainer splitContainerRightP;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.SplitContainer splitContainerDG;
        private System.Windows.Forms.Panel panelPassTests;
        private System.Windows.Forms.Button buttonPassTest;
        private System.Windows.Forms.ComboBox comboBoxGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Panel panelForPanelTest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.SplitContainer splitContainerAnsBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelSpanTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelQuestionCount;
    }
}