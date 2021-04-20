using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        /* Створити додаток -Дизайнер тестів
         * Реалізувати можливість:
         * 1. додавання нових тестів
         * 2. редагування існуючих тестів
         * На виході програма повинна формувати xml документ з переліком питань та відповідями 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CourseWorkTest";
            this.groupBox1.Text = "Test";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            FormNewTest form = new FormNewTest();
            form.Text = this.Text;

            form.Owner = this;

            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel) this.Show();

            form = null;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEdit form = new FormEdit();
            form.Text = this.Text;

            form.Owner = this;

            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel) this.Show();

            form = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
