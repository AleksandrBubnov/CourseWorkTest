using System;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace TestClientApp
{
    public partial class FormClientMain : Form
    {
        private DALServerDB.Data data;
        private NetworkStream stream;
        private TcpClient client;
        string symbSeparator = " / ";
        private Stopwatch stopwatch;
        private TimeSpan timeSpan;
        private int questionCount;
        private int questionTotal;
        //private ListBox ListBox1;
        public FormClientMain()
        {
            InitializeComponent();
        }
        public FormClientMain(DALServerDB.Data data, NetworkStream stream, TcpClient client)
        {
            InitializeComponent();

            this.data = data;
            this.stream = stream;
            this.client = client;

            labelSelected.Text = string.Empty;
            labelFLName.Text = data.FName + " " + data.LName;
            FillComboBoxGroupName(data.Groups);

            SplitContainerDGSplitterDistance(panelPassTests.Height);
        }
        private void SplitContainerDGSplitterDistance(int height)
        {
            splitContainerDG.SplitterDistance = splitContainerDG.Height -
                height -
                splitContainerDG.SplitterWidth -
                splitContainerDG.Margin.Bottom -
                splitContainerDG.Margin.Top;
        }
        private void FillComboBoxGroupName(List<string> groups)
        {
            groups.ForEach(g => comboBoxGroupName.Items.Add(g));
        }
        private void FormClientMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.IsPassing = false;
            data.IsWorking = false;
            GetRequest(DALServerDB.Request.Working);
            if (client != null) client?.Close();
            if (stream != null) stream?.Close();
            if (e.CloseReason != CloseReason.FormOwnerClosing) this.Owner.Close();
        }
        private void comboBoxGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRequest(DALServerDB.Request.Group, comboBoxGroupName.SelectedItem.ToString());
        }
        //private async void GetRequestAsync(Request request, string str = null)
        //{
        //    await Task.Run(() => GetRequest(request, str));
        //}

        private void GetRequest(DALServerDB.Request request, string str = null)
        {
            SetcheckedListBoxUnChecked();
            switch (request)
            {
                case DALServerDB.Request.Group:
                    #region
                    data.IsGroup = true;
                    data.Group = str;
                    comboBoxGroupName.Invoke(new Action(() => comboBoxGroupName.Enabled = false));
                    GetResponce();
                    if (data.Tests == null)
                    {
                        MessageBox.Show(Environment.NewLine + "data.Tests == null!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (data.Tests.ToList().Count == 0) MessageBox.Show(Environment.NewLine + "data.Tests.ToList().Count == 0!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    listView1.Invoke(new Action(() =>
                    {
                        listView1.Items.Clear();
                        foreach (var item in data.Tests)
                        {
                            ListViewItem name = new ListViewItem();
                            name.Text = item.Id.ToString();
                            name.SubItems.Add(item.Title);
                            name.SubItems.Add(item.Author);
                            name.SubItems.Add(item.Time.ToString());
                            listView1.Items.Add(name);
                        }
                    }
                    ));
                    comboBoxGroupName.Invoke(new Action(() => comboBoxGroupName.Enabled = true));
                    data.IsGroup = false;
                    #endregion
                    break;
                case DALServerDB.Request.Working:
                    GetResponce();
                    break;
                case DALServerDB.Request.Test:
                    data.IsTest = true;
                    GetResponce();
                    data.IsTest = false;
                    break;
                case DALServerDB.Request.QuestionStart:
                    data.IsStart = true;
                    data.IsPassing = true;
                    GetResponce();
                    ClearQuestionAnswears();
                    FillQuestionAnswears();
                    questionCount++;
                    data.IsStart = false;
                    break;
                case DALServerDB.Request.QuestionNext:
                    data.IsPassing = true;
                    GetResponce();
                    questionCount++;
                    ClearQuestionAnswears();
                    FillQuestionAnswears();
                    break;
                case DALServerDB.Request.QuestionLast:
                    data.IsPassing = false;

                    if (data.IsLast)
                    {
                        GetResponce();
                        data.IsLast = false;
                        questionCount = 0;
                        PassedTestMessage();
                        PanelTestVisibleFalse();
                    }

                    timer1.Stop();
                    labelSpanTime.Text = "00:00:00";
                    stopwatch.Stop();
                    stopwatch.Reset();
                    break;
            }
        }
        private void PanelTestVisibleFalse()
        {
            panelTest.Visible = false;
            buttonStart.Enabled = true;
            buttonNext.Enabled = false;
            panelTest.Enabled = false;
            textBoxQuestion.Visible = false;
            checkedListBox1.Visible = false;

            splitContainerFullScreen.Visible = true;
        }
        private void PassedTestMessage()
        {
            MessageBox.Show(Environment.NewLine + $"QtyOfRightAnswers / QuestionQty => {data.QtyOfRightAnswers} / {data.QuestionQty}" +
                Environment.NewLine + $"ResultMark: {data.ResultMark}", this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearQuestionAnswears()
        {
            textBoxQuestion.Invoke(new Action(() => textBoxQuestion.Text = string.Empty));
            //checkedListBox1.Invoke(new Action(() => checkedListBox1.Items.Clear()));
        }
        private void FillQuestionAnswears()
        {
            textBoxQuestion.Invoke(new Action(() => textBoxQuestion.Text = data.Question));

            checkedListBox1.Invoke(new Action(() =>
            {
                checkedListBox1.DataSource = data.Answears;
                checkedListBox1.DisplayMember = "Description";
                checkedListBox1.ValueMember = "Id";
            }));
            //ListBox1.Invoke(new Action(() =>
            //{
            //    ListBox1.Items.Clear();
            //    ListBox1.DataSource = data.Answears;
            //    ListBox1.DisplayMember = "Description";
            //    ListBox1.ValueMember = "Id";
            //}));
            //checkedListBox1.Invoke(new Action(() =>
            //{
            //    checkedListBox1.Items.Clear();
            //    foreach (var key in data.Answears)
            //    {
            //        checkedListBox1.Items.Add(key.Description);
            //    }
            //}));
        }
        private void GetResponce()
        {
            try
            {
                new BinaryFormatter().Serialize(client.GetStream(), data);

                data = (DALServerDB.Data)new BinaryFormatter().Deserialize(stream);
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Environment.NewLine + ex.Message + Environment.NewLine, this.Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            catch { }
        }

        private void buttonPassTest_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                splitContainerFullScreen.Visible = false;
                panelTest.Visible = true;
                panelTest.Enabled = true;

                labelQuestionCount.Text = "0 / 0";
                labelSpanTime.Text = "00:00:00 / 00:00:00";
                questionCount = 0;
                questionTotal = 0;
                stopwatch = new Stopwatch();

                int tmpId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                data.TestId = tmpId;
                timeSpan = data.Tests.FirstOrDefault(z => z.Id == tmpId).Time;
                GetRequest(DALServerDB.Request.Test);
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxQuestion.Text = string.Empty;
            textBoxQuestion.Visible = true;
            checkedListBox1.Visible = true;
            SetcheckedListBoxUnChecked();

            buttonStart.Enabled = false;
            buttonNext.Enabled = true;

            timer1.Start();
            stopwatch.Start();

            data.IsWorking = true;
            data.IsGroup = false;
            data.IsTest = false;
            data.IsPassing = false;
            data.IsStart = false;
            data.IsLast = false;


            GetRequest(DALServerDB.Request.QuestionStart);
            questionTotal = data.QuestionQty;
        }
        private void SetcheckedListBoxUnChecked()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.SetItemChecked(i, false);

                }
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                data.AnswearId = (item as DALServerDB.AnswearForData).Id;
            }
            if (checkedListBox1.CheckedItems.Count == 0) data.AnswearId = null;

            if (questionCount >= questionTotal) { data.IsLast = true; }

            if (data.IsLast)
                GetRequest(DALServerDB.Request.QuestionLast);
            else
                GetRequest(DALServerDB.Request.QuestionNext);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelQuestionCount.Text = questionCount.ToString() + symbSeparator + questionTotal.ToString();
            labelSpanTime.Text = (timeSpan - stopwatch.Elapsed).ToString(@"hh\:mm\:ss") + symbSeparator + timeSpan.ToString(@"hh\:mm\:ss");

            if (timeSpan <= stopwatch.Elapsed)
            {
                data.IsLast = true;
                GetRequest(DALServerDB.Request.QuestionLast);
            }
        }
    }
}
