using Tyuiu.SivolapEM.Sprint6.Task1.V25.Lib;

namespace Tyuiu.SivolapEM.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_AAF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 1 âûïîëíèë ñòóäåíò ãðóïïû ÐÏÏá-24-1 Àëüøèí Àðòóð Ôàðèòîâè÷", "Ñîîáùåíèå");
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBoxTask_AAF.Image = Image.FromFile(@"C:\Users\User\Downloads\formula.jpg");
        }
        DataService ds = new DataService();
        private void buttonDone_AAF_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_AAF.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AAF.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_AAF.Text = "";
                textBoxResult_AAF.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_AAF.AppendText("|      x   |    f(x)  | " + Environment.NewLine);
                textBoxResult_AAF.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_AAF.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_AAF.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíû äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_AAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartValue_AAF_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxStopValue_AAF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
