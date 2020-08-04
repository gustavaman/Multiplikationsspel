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
        Stopwatch time = new Stopwatch();
        Random rnd = new Random();
        List<string> multtable = new List<string>();
        List<Label> box = new List<Label>();
        List<Label> number = new List<Label>();

        public Form1()
        {
            InitializeComponent();

            answer.Hide();

            timer.Hide();

            solved.Hide();

            int q = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int p = 0; p < 10; p++)
                {
                    box.Add(new System.Windows.Forms.Label { Location = new Point(590 + p * 25, 265 - i * 25), Size = new Size(20, 20), BackColor = Color.Coral });
                    this.Controls.Add(box[q]);
                    q++;
                }
            }

            for (int i = 1; i < 11; i++)
            {
                number.Add(new System.Windows.Forms.Label { Location = new Point(570, 294 - i * 25), Text = i.ToString(), ForeColor = Color.Coral, Size = new Size(19, 11) });
                this.Controls.Add(number[i - 1]);
            }

            for (int i = 1; i < 11; i++)
            {
                number.Add(new System.Windows.Forms.Label { Location = new Point(568 + i * 25, 294), Text = i.ToString(), ForeColor = Color.Coral, Size = new Size(19, 11) });
                this.Controls.Add(number[i + 9]);
            }
        }

        void BoxLogic()
        {
            int c = 0;
            for (int i = 1; i < 11; i++)
            {
                for (int p = 1; p < 11; p++)
                {
                    if (i <= int.Parse(display.Text.Split('·')[0]) && p <= int.Parse(display.Text.Split('·')[1]))
                        box[c].BackColor = Color.Red;
                    else
                        box[c].BackColor = Color.Coral;
                    c++;
                }
            }
        }

        public void start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int p = 0; p <= 10; p++)
                    if (p >= i)
                        multtable.Add(i + "·" + p);
            for (int i = 0; i < 20; i++)
                number[i].ForeColor = Color.Black;
            solved.Text = "Lösta: 0/66";
            solved.Show();
            timer.Hide();
            startrandom.Hide();
            answer.Show();
            display.Text = multtable[rnd.Next(0, multtable.Count)];
            BoxLogic();
            time.Reset();
            time.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && answer.Text.Length > 0)
                answer.Text = answer.Text.Remove(answer.Text.Length - 1);
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.NumPad0)
            {
                char[] alfa = { '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
                if (alfa.Contains((char)e.KeyCode))
                {
                    for (int i = 0; i < 10; i++)
                        if (alfa[i] == (char)e.KeyCode)
                            answer.Text += i;
                }
                else
                    answer.Text += (char)e.KeyCode;
            }

            if (display.Text.Contains("·") && answer.Text == (int.Parse(display.Text.Split('·')[0]) * int.Parse(display.Text.Split('·')[1])).ToString() && multtable.Count != 1)
            {
                multtable.Remove(display.Text);
                display.Text = multtable[rnd.Next(0, multtable.Count)];
                answer.Text = "";
                solved.Text = "Lösta: " + (66 - multtable.Count).ToString() + "/66";
                BoxLogic();
            }
            else if (display.Text.Contains("·") && answer.Text == (int.Parse(display.Text.Split('·')[0]) * int.Parse(display.Text.Split('·')[1])).ToString() && multtable.Count == 1)
            {
                multtable.Remove(display.Text);
                for (int i = 0; i < 20; i++)
                    number[i].ForeColor = Color.Coral;
                for (int i = 0; i < 100; i++)
                    box[i].BackColor = Color.Coral;
                time.Stop();
                display.Text = "Bra jobbat! :)";
                answer.Text = "";
                answer.Hide();
                solved.Hide();
                startrandom.Show();
                timer.Show();
                timer.Text = (time.ElapsedMilliseconds - time.ElapsedMilliseconds % 60000) / 60000 + " min " + time.ElapsedMilliseconds % 60000 / 1000 + " s";
            }
        }
    }
}
