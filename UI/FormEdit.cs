using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using XmlClassLibrary;

namespace UI
{
    public partial class FormEdit : Form
    {
        Test Test;
        bool isBack = false;
        //bool isRight = false;
        //string xmlExtension = ".xml";
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = Filter;
            openFileDialog1.FilterIndex = 0;
            ClearForm();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CurrentDocName = openFileDialog1.FileName;
                    XmlSerializer serializer = new XmlSerializer(Test.GetType());
                    using (FileStream fs = new FileStream(CurrentDocName, FileMode.OpenOrCreate))
                    {
                        Test = (Test)serializer.Deserialize(fs);
                        FillForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FillForm()
        {
            textBoxAuthor.Text = Test.Author;
            textBoxTitle.Text = Test.TestName;
            textBoxQtyQuestion.Text = Test.Qty_questions;

            foreach (var item in Test.Question)
            {
                listBoxQuestion.Items.Add(item.Description);
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

        private void listBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuestion.SelectedIndex != -1)
            {
                try
                {
                    textBoxQuestion.Text = listBoxQuestion.SelectedItem.ToString();
                    var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString());
                    numericUpDownDifficulty.Value = Convert.ToDecimal(tmp.Difficulty);

                    comboBoxAnswear.Items.Clear();
                    foreach (var item in tmp.Answer) comboBoxAnswear.Items.Add(item.Description);

                    if (comboBoxAnswear.Items.Count > 0) comboBoxAnswear.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBoxAnswear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnswear.SelectedIndex != -1)
            {
                try
                {
                    textBoxAnswear.Text = comboBoxAnswear.SelectedItem.ToString();
                    var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString()).
                        Answer.FirstOrDefault(y => y.Description == comboBoxAnswear.SelectedItem.ToString());

                    checkBoxIsRight.Checked = Convert.ToBoolean(tmp.IsRight);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestion.SelectedIndex != -1 && listBoxQuestion.Items.Count > 1)
            {
                var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString());
                Test.Question.Remove(tmp);

                comboBoxAnswear.Items.Clear();
                comboBoxAnswear.SelectedIndex = -1;
                textBoxAnswear.Text = string.Empty;

                listBoxQuestion.Items.RemoveAt(listBoxQuestion.SelectedIndex);
                textBoxQuestion.Text = string.Empty;
                textBoxQtyQuestion.Text = Test.Question.Count.ToString();
            }
        }
        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestion.SelectedIndex != -1)
            {
                var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString());
                tmp.Description = textBoxQuestion.Text;
                tmp.Difficulty = numericUpDownDifficulty.Value.ToString();

                comboBoxAnswear.Items.Clear();
                comboBoxAnswear.SelectedIndex = -1;
                textBoxAnswear.Text = string.Empty;

                int index = listBoxQuestion.SelectedIndex;
                listBoxQuestion.Items.Insert(index, textBoxQuestion.Text);
                listBoxQuestion.Items.RemoveAt(index + 1);
                textBoxQuestion.Text = string.Empty;
            }
        }

        private void buttonRemoveAnswear_Click(object sender, EventArgs e)
        {
            if (comboBoxAnswear.SelectedIndex != -1 && comboBoxAnswear.Items.Count > 2)
            {
                var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString()).
                    Answer.FirstOrDefault(y => y.Description == comboBoxAnswear.SelectedItem.ToString());

                Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString()).Answer.Remove(tmp);
                var tmpQuestion = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString());
                comboBoxAnswear.Items.Clear();
                foreach (var item in tmpQuestion.Answer) comboBoxAnswear.Items.Add(item.Description);

                if (comboBoxAnswear.Items.Count > 0) comboBoxAnswear.SelectedIndex = 0;
                else comboBoxAnswear.SelectedIndex = -1;
                textBoxAnswear.Text = string.Empty;
            }
        }
        private void buttonEditAnswear_Click(object sender, EventArgs e)
        {
            if (comboBoxAnswear.SelectedIndex != -1)
            {
                var tmp = Test.Question.FirstOrDefault(x => x.Description == listBoxQuestion.SelectedItem.ToString()).
                    Answer.FirstOrDefault(y => y.Description == comboBoxAnswear.SelectedItem.ToString());
                tmp.Description = textBoxAnswear.Text;
                tmp.IsRight = checkBoxIsRight.Checked.ToString();

                int index = comboBoxAnswear.SelectedIndex;
                comboBoxAnswear.Items.Insert(index, textBoxAnswear.Text);
                comboBoxAnswear.Items.RemoveAt(index + 1);
                textBoxAnswear.Text = string.Empty;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAuthor.Text) &&
                !string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                string path = CurrentDocName;

                //// check path block - start
                //if (path.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                //{
                try { FileInfo fileInfo = new FileInfo(path); path = fileInfo.Name; }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show("NotSupportedException" + Environment.NewLine + ex.Message, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // check path block - end
                if (File.Exists(path))
                {
                    Test.Author = textBoxAuthor.Text;
                    Test.TestName = textBoxTitle.Text;
                    Test.Qty_questions = textBoxQtyQuestion.Text;
                    XmlSerializer serializer = new XmlSerializer(Test.GetType());
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        serializer.Serialize(fs, Test);

                        MessageBox.Show($"File [{CurrentDocName}] Saved" + Environment.NewLine, this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CurrentDocName = string.Empty;
                        ClearForm();
                    }
                }
                else
                    MessageBox.Show($"File.notExists({CurrentDocName})" + Environment.NewLine, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //    MessageBox.Show($"{CurrentDocName} => InvalidFileNameCharsExists()" + Environment.NewLine, this.Text,
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
