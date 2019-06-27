using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace GraZaDuzoZaMalo
{
    public partial class Form1 : Form
    {
        private int drawNumber,Time,Count;
        string name = "Gość";
        int index = 1;
        DataTable dt = new DataTable();

        private static int Rand(int min, int max)
        {
            Random generator = new Random();
            return generator.Next(min, max);

        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Anuluj";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Lp.");
            dt.Columns.Add("Imię");
            dt.Columns.Add("Czas");
            dt.Columns.Add("Liczba prób");
            dt.Columns.Add("Łącznie punktów");
            InputBox("Witaj ! jak się nazywasz ?", "Mam na imię :", ref name);
            TBName.Text = name;
            drawNumber = 0;
            Time = 0;
            Count = 0;
            PBGame.Hide();
        }

        private static bool IsAnimating(PictureBox box)
        {
            var fi = box.GetType().GetField("currentlyAnimating",
                BindingFlags.NonPublic | BindingFlags.Instance);
            return (bool)fi.GetValue(box);
        }
        private static void Animate(PictureBox box, bool enable)
        {
            var anim = box.GetType().GetMethod("Animate",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(bool) }, null);
            anim.Invoke(box, new object[] { enable });
        }
        private void TBFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double pointsTotal(int to,int from)
        {
            double res = (Math.Abs(to - from) * 10) - (Time * (Count + Time / 5));
            if (res < 0)
            {
                res = 0;
            }

            return res;
        }

        private void TBTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Stop()
        {
            Time = 0;
            Count = 0;
            LPointsRes.Text = "0";
            LTimeRes.Text = Time.ToString() + " s";
            LCountRes.Text = Count.ToString();
            LDecide.Text = "";
            TBGame.Text = "";
            PBGame.Hide();
            timer1.Enabled = false;
            PBLoading.Image = Properties.Resources.wait;
            LWinNumber.Visible = false;
            TBGame.Enabled = false;
            BTNGame.Enabled = false;
            BTNStop.Enabled = false;
            PBWinner.Visible = false;
            BTNRand.Enabled = true;
            TBFrom.Enabled = true;
            TBTo.Enabled = true;
        }

        private void AddToHistory(int time, int count,string userName,double points)
        {
            DataRow dr = dt.NewRow();
             
            dr[0] = index;
            dr[1] = userName;
            dr[2] = time;
            dr[3] = count;
            dr[4] = points;
            dt.Rows.Add(dr);
            index++;
        }

        private void Start()
        {
            Time = 0;
            Count = 0;
            LPointsRes.Text = "0";
            LTimeRes.Text = Time.ToString() + " s";
            LCountRes.Text = Count.ToString();
            LDecide.Text = "";
            TBGame.Text = "";
            timer1.Enabled = true;
            PBLoading.Image = Properties.Resources.search;
            LWinNumber.Visible = false;
            TBGame.Enabled = true;
            BTNGame.Enabled = true;
            PBWinner.Visible = false;
            BTNStop.Enabled = true;
            BTNRand.Enabled = false;
            TBFrom.Enabled = false;
            TBTo.Enabled = false;
            int from = Convert.ToInt32(TBFrom.Text);
            int to = Convert.ToInt32(TBTo.Text);
            drawNumber = Rand(from, to);
            PBGame.Image = Properties.Resources.random_numbers;
            PBGame.Show();
        }

        private void Win()
        {
            int from = Convert.ToInt32(TBFrom.Text);
            int to = Convert.ToInt32(TBTo.Text);
            PBWinner.Visible = true;
            AddToHistory(Time, Count, name,pointsTotal(to,from));
            LPointsRes.Text = pointsTotal(to, from).ToString();
            timer1.Enabled = false;
            PBGame.Image = Properties.Resources.random_numbers_empty;
            LWinNumber.Visible = true;
            PBLoading.Image = Properties.Resources.wait;
            TBGame.Enabled = false;
            BTNGame.Enabled = false;
            BTNStop.Enabled = false;
            BTNRand.Enabled = true;
            TBFrom.Enabled = true;
            TBTo.Enabled = true;
        }

        private void CheckIfCorrect()
        {
            string temp = "0";
            int from = Convert.ToInt32(TBFrom.Text);
            int to = Convert.ToInt32(TBTo.Text);

            if(from > to)
            {
                temp = TBFrom.Text;
                TBFrom.Text = TBTo.Text;
                TBTo.Text = temp;
            }
        }

        private void ChangePictureBoxState(PictureBox box)
        {
            Animate(box, !IsAnimating(box));
        }

        private void OnRandException(Exception error)
        {
            if (TBFrom.Text == "" || TBTo.Text == "")
            {
                if (TBFrom.Text == "")
                {
                    TBFrom.Text = "0";
                }

                if (TBTo.Text == "")
                {
                    TBTo.Text = "100";
                }
            }
            else
            {
                MessageBox.Show(error.Message);
            }
        }

        private void OnGameException(Exception error)
        {
            if (TBGame.Text == "")
            {
                if (TBGame.Text == "")
                {
                    TBGame.Text = "0";
                }
            }
            else
            {
                MessageBox.Show(error.Message);
            }
        }

        private void CheckIfWin(int value)
        {
            Count++;
            LCountRes.Text = Count.ToString();
            if(value == drawNumber)
            {
                LDecide.Text = "TRAFIŁEŚ";
                LWinNumber.Text = value.ToString();
                Win();
            } else if(value > drawNumber)
            {
                LDecide.Text = "ZA DUŻO";
            } else if(value < drawNumber)
            {
                LDecide.Text = "ZA MAŁO";
            }
        }

        private void TBGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNGame_Click(this, new EventArgs());
            }
        }

        private void BTNGame_Click(object sender, EventArgs e)
        {
            try
            {
                CheckIfWin(Convert.ToInt32(TBGame.Text));
            }
            catch (Exception error)
            {
                OnGameException(error);
            }
        }

        private void BTNRand_Click(object sender, EventArgs e)
        {
            try
            {
                CheckIfCorrect();
                Start();
            }
            catch (Exception error)
            {
                OnRandException(error);
            }
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(TBFrom.Text);
            int to = Convert.ToInt32(TBTo.Text);
            LPointsRes.Text = pointsTotal(to, from).ToString();
            Time++;
            LTimeRes.Text = Time.ToString() + " s";
        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void BTNHistory_Click(object sender, EventArgs e)
        {
                Form2 f2 = new Form2(dt);
                f2.ShowDialog();
        }

        private void TBName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(TBName.Text == "")
                {
                    TBName.Text = "Gość";
                }

                name = TBName.Text;
            }
        }

        private void TBFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNRand_Click(this, new EventArgs());
            }
        }

        private void TBTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNRand_Click(this, new EventArgs());
            }
        }
    }
}
