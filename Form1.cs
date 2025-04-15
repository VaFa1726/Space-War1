using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace yu
{
    public partial class Form1 : Form
    {
        public string usernname = "name.txt";
        public string pas = "password.txt";
        int shomareshklick = 0;
        int maksodsanie = 10;
        public string mmd = "mmd";

        public Form1()
        {
            InitializeComponent();
            vorody2.PasswordChar = '*';
            this.KeyPreview = true;



            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 4 - 50,
                150
            );


        }
        public static class GlobalData
        {
            public static string playerName = "Default";
            public static int playerScore = 0;
        }
        private void Khoroj(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pak(object sender, EventArgs e)
        {
            vorody1.Clear();
            vorody2.Clear();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            //if (e.KeyCode == Keys.W)
            //{
            //    Form2 form2 = new Form2(this);
            //    form2.Show();
            //    this.Hide();
            //}
            if (e.KeyCode == Keys.F1)
            {
                if (File.Exists(usernname) && File.Exists(pas))
                {

                    string esm = File.ReadAllText(usernname);
                    string ramz = File.ReadAllText(pas);
                    MessageBox.Show("username: " + esm + "\npassword: " + ramz);
                }
                else
                {
                    MessageBox.Show("Username or password file does not exist.");
                }
            }
        }
        private void pak()
        {
            vorody1.Clear();
            vorody2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            shomareshklick += 1;



            string esm = File.ReadAllText(usernname);
            string ramz = File.ReadAllText(pas);

            if (vorody1.Text == esm && vorody2.Text == ramz)
            {

                string username = File.ReadAllText(usernname);

                Form2 frm2 = new Form2(this);
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = this.Location;
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error: Invalid username or password", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pak();
            if (shomareshklick == 3)
            {
                timer1.Start();
                timerbazshdan.Start();
            }


        }
        public void num()
        {
            int mmd = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    Form2 frm2 = new Form2(this);
            //    Form4 form4 = new Form4(frm2);
            //    form4.Show();
            //    this.Hide();
        }


    
        private void timerbazshdan_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            vorody1.Enabled = true;
            vorody2.Enabled = true;
            tagbuutonbaz();
            labeltimer.Visible = false;
        }
        private void tagbuuton()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "buttonform1")
                {
                    x.Enabled = false;
                }
            }
        }
        private void tagbuutonbaz()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "buttonform1")
                {
                    x.Enabled = true;
                }
            }
        }
        public static class pickcher
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (shomareshklick == 3)
            {
                vorody1.Enabled = false;
                vorody2.Enabled = false;
                maksodsanie--;
                labeltimer.Text = $"Time left:{maksodsanie}";
                tagbuuton();

            }
        }
    }
}

