using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplikationsspel
{
    public partial class Form1 : Form
    {
        bool random;
        Stopwatch time = new Stopwatch();
        Random rnd = new Random();
        List<string> multtable = new List<string>();
        public string MultTableGenerator(int a)
        {
            List<string> multtable = new List<string>();

            for (int i = 0; i <= 10; i++)
            {
                for (int p = 0; p <= 10; p++)
                {
                    if (p >= i)
                    {
                        multtable.Add(i + "·" + p);
                    }
                }
            }

            return multtable[a];
        }

        public Form1()
        {
            InitializeComponent();

            answer.Hide();

            timer.Hide();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public void start_Click(object sender, EventArgs e)
        {
            if (sender == start)
                random = false;
            else
                random = true;
            for (int i = 0; i <= 10; i++)
            {
                for (int p = 0; p <= 10; p++)
                {
                    if (p >= i)
                    {
                        multtable.Add(i + "·" + p);
                    }
                }
            }

            timer.Hide();
            start.Hide();
            startrandom.Hide();
            answer.Show();
            if (!random)
                display.Text = multtable[0];
            if (random)
                display.Text = multtable[rnd.Next(0, multtable.Count)];
            time.Reset();
            time.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && answer.Text.Length > 0)
                answer.Text = answer.Text.Remove(answer.Text.Length - 1);
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.D0)
                answer.Text += (char)e.KeyCode;
            if (display.Text.Contains("·") && answer.Text == (int.Parse(display.Text.Split('·')[0]) * int.Parse(display.Text.Split('·')[1])).ToString() && multtable.Count != 1)
            {
                multtable.Remove(display.Text);
                if (!random)
                    display.Text = multtable[0];
                if (random)
                    display.Text = multtable[rnd.Next(0, multtable.Count)];
                answer.Text = "";
            }
            else if (display.Text.Contains("·") && answer.Text == (int.Parse(display.Text.Split('·')[0]) * int.Parse(display.Text.Split('·')[1])).ToString() && multtable.Count == 1)
            {
                time.Stop();
                display.Text = "";
                answer.Hide();
                start.Show();
                startrandom.Show();
                timer.Show();
                timer.Text = (time.ElapsedMilliseconds / 1000).ToString() + " sekunder.";
            }
        }
    }
}
