using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyTarot
{
    public partial class Form1 : Form
    {

        List<string> advices;

        public Form1()
        {
            InitializeComponent();
            LoadAdvice();
        }

        private void LoadAdvice()
        {
            try
            {
                string filename = "tarot_advice.csv";
                advices = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없음. \n{ex.Message}", "파일이 없는 오류!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없음. \n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생함. \n{ex.Message}", "알 수 없는 오류!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAdvice()
        {
            Random random = new Random();
            int index = random.Next(0, advices.Count);
            return advices[index];
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myTarot정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string worry = tbWorry.Text;
            string result = GetAdvice();
            tbResult.Text = worry + Environment.NewLine + result;
            SaveHistory($"{worry} | {result}");

        }

        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없음. \n{ex.Message}", "권한 오류");
            }
            catch (Exception ex) {
                MessageBox.Show($"알 수 없는 오류 발생. \n{ex.Message}", "알 수 없는 오류 발생");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 결과불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        // 카드 누르면 결과 나오게 하는 건 구현 예정
        private void btnCard1_Click(object sender, EventArgs e)
        {
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {

        }

        private void btnCard3_Click(object sender, EventArgs e)
        {

        }

        private void btnCard4_Click(object sender, EventArgs e)
        {

        }
    }
}
