using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
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
        {// спряч таскбар

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
