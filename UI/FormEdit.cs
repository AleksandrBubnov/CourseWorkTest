using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlClassLibrary;

namespace UI
{
    public partial class FormEdit : Form
    {
        Test Test;
        bool isRight = false;
        bool isBack = false;
        string xmlExtension = ".xml";
        private string CurrentDocName { get; set; } = "test";
        private string Filter { get; set; } = "XML files (*.xml)|*.xml";
        public FormEdit()
        {
            InitializeComponent();
            Test = new Test();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            this.Text += "." + "FormEdit";
        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isBack) Application.Exit();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            isBack = true;
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Filter;
            openFileDialog1.FilterIndex = 0;
            ClearForm();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Serializer serializer = new Serializer();
                    // Deserialize<Source> - типизируем классом что соответствует корневому элементу в xml файле
                    CurrentDocName = openFileDialog1.FileName;
                    Test = serializer.Deserialize<Test>(CurrentDocName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            Test = new Test();

            textBoxAuthor.Text = string.Empty;
            textBoxTitle.Text = string.Empty;
            textBoxQtyQuestion.Text = string.Empty;

            listBoxQuestion.Items.Clear();
            textBoxQuestion.Text = string.Empty;
            numericUpDownDifficulty.Value = 1;

            comboBoxAnswear.Items.Clear();
            checkBoxIsRight.Checked = false;
            textBoxAnswear.Text = string.Empty;
        }
    }
}
