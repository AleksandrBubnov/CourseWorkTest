using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using XmlClassLibrary;

namespace UI
{
    public partial class FormNewTest : Form
    {
        Test Test;
        bool isRight = false;
        bool isBack = false;
        string xmlExtension = ".xml";
        public FormNewTest()
        {
            InitializeComponent();
            Test = new Test();
        }

        private void FormNewTest_Load(object sender, EventArgs e)
        {
            this.Text += "." + "FormNewTest";
        }

        private void FormNewTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isBack) Application.Exit();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            isBack = true;
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuestion.Text)) buttonAddQuestion.Enabled = false;
            else buttonAddQuestion.Enabled = true;
        }
        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxQuestion.Text))
            {
                Test.Question.Add(new Question()
                {
                    Description = textBoxQuestion.Text,
                    Difficulty = numericUpDownDifficulty.Value.ToString()
                });
                textBoxQtyQuestion.Text = Test.Question.Count.ToString();
                textBoxQuestion.ReadOnly = true;
                buttonAddQuestion.Hide();
                numericUpDownDifficulty.Enabled = false;

                textBoxAnswear.Enabled = true;
                textBoxAnswear.Focus();
            }
        }

        private void textBoxAnswear_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAnswear.Text)) buttonAddAnswear.Enabled = false;
            else buttonAddAnswear.Enabled = true;
        }
        private void buttonAddAnswear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAnswear.Text))
            {
                Test.Question[Test.Question.Count - 1].Answer.Add(new Answer()
                {
                    Description = textBoxAnswear.Text,
                    IsRight = checkBoxIsRight.Checked.ToString()
                });

                if (checkBoxIsRight.Checked) isRight = checkBoxIsRight.Checked;
                if (Test.Question[Test.Question.Count - 1].Answer.Count >= 2 &&
                    isRight &&
                    Test.Question[Test.Question.Count - 1].Answer.Distinct(new AnswerEqualityComparer()).Count() > 1)
                {
                    buttonNextQuestion.Enabled = true;
                }

                listBoxAnswear.Items.Add(textBoxAnswear.Text);

                textBoxAnswear.Text = string.Empty;
                textBoxAnswear.Focus();
                checkBoxIsRight.Checked = false;
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            textBoxQuestion.Focus();
            textBoxQuestion.ReadOnly = false;
            textBoxQuestion.Text = string.Empty;
            buttonAddQuestion.Show();
            numericUpDownDifficulty.Enabled = true;

            isRight = false;
            buttonNextQuestion.Enabled = false;
            listBoxAnswear.Items.Clear();
            textBoxAnswear.Enabled = false;
            checkBoxIsRight.Checked = true;

            if (Test.Question.Count > 1) textBoxSave.Enabled = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ButtonSaveEnabled();
        }
        private void ButtonSaveEnabled()
        {
            if (string.IsNullOrWhiteSpace(textBoxSave.Text) ||
                string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                string.IsNullOrWhiteSpace(textBoxTitle.Text))
                buttonSave.Enabled = false;
            else buttonSave.Enabled = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSave.Text))
            {
                string path = textBoxSave.Text;
                if (!path.EndsWith(xmlExtension)) path += xmlExtension;
                // check path block - start
                if (path.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                {
                    try { FileInfo fileInfo = new FileInfo(path); }
                    catch (NotSupportedException ex)
                    {
                        MessageBox.Show("NotSupportedException" + Environment.NewLine + ex.Message, this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // check path block - end
                    if (!File.Exists(path))
                    {
                        Test.Author = textBoxAuthor.Text;
                        Test.TestName = textBoxTitle.Text;
                        Test.Qty_questions = textBoxQtyQuestion.Text;
                        XmlSerializer serializer = new XmlSerializer(Test.GetType());
                        using (FileStream fs = new FileStream(path, FileMode.CreateNew))
                        {
                            serializer.Serialize(fs, Test);

                            MessageBox.Show($"File [{textBoxSave.Text}] Saved" + Environment.NewLine, this.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBoxSave.Text = string.Empty;
                        }
                    }
                    else
                        MessageBox.Show($"File.Exists({textBoxSave.Text})" + Environment.NewLine, this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"{textBoxSave.Text} => InvalidFileNameCharsExists()" + Environment.NewLine, this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
