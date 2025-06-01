using System;
using System.Windows.Forms;
using static yu.Form1;
using static yu.Form3;

namespace yu
{
    public partial class Form4 : Form
    {
        private Form2 form2;
        int afzaiesh = 0;
        int afzaiesh2 = 0;
        int afzaiesh3 = 0;
        string power = "speed.txt";
        string power1 = "speed1.txt";
        string power2 = "speed2.txt";
        public string jet = "";

        public Form4(Form2 form2Instance)
        {
            InitializeComponent();
            form2 = form2Instance;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = form2.Location;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 3 - 50,
                100
            );
            jet1.Click += jet_Click;
            jet2.Click += jet_Click;
            jet3.Click += jet_Click;
            playerasly.Click += jet_Click;
            lodemonay();


        }


        private void jet_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(form2);

            PictureBox clickedPic = sender as PictureBox;
            string num = File.ReadAllText("filepool.txt");
            label1.Text = num;
            int userMoney = int.Parse(label1.Text);
            if (clickedPic.Image == jet1.Image && userMoney >= 500)
            {
                userMoney -= 500;
                File.WriteAllText("filepool.txt", userMoney.ToString());
                label1.Text = userMoney.ToString();
                form3.SetImageToPictureBox(clickedPic.Image);
                playerasly.Image = clickedPic.Image;
                form3.playerspeed = 22;
                form3.Show();
                this.Close();
            }
            if (clickedPic.Image == jet2.Image && userMoney >= 1500)
            {
                userMoney -= 1500;
                File.WriteAllText("filepool.txt", userMoney.ToString());
                label1.Text = userMoney.ToString();
                form3.SetImageToPictureBox(clickedPic.Image);
                playerasly.Image = clickedPic.Image;

                form3.playerspeed = 32;
                form3.Show();
                this.Close();
            }
            if (clickedPic.Image == jet3.Image && userMoney >= 1500)
            {
                userMoney -= 3000;
                File.WriteAllText("filepool.txt", userMoney.ToString());
                label1.Text = userMoney.ToString();
                form3.SetImageToPictureBox(clickedPic.Image);

                playerasly.Image = clickedPic.Image;
                form3.playerspeed = 42;
                form3.Show();
                this.Close();
            }
            if (clickedPic.Image == playerasly.Image)
            {
                playerasly.Image = clickedPic.Image;
                form3.SetImageToPictureBox(clickedPic.Image);
                form3.playerspeed = 12;
                form3.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("موجودی شما کافی نیست!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        private void player1_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Show();
                this.Hide();
            }
        }
        private void lodemonay()
        {
            string monay = File.ReadAllText("filepool.txt");
            label1.Text = monay;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalData.playerName);
        }



        private void buttonafzaiesh_Click(object sender, EventArgs e)
        {
            if (afzaieshe1.Value < afzaieshe1.Maximum)
            {
                afzaiesh += 1;
                afzaieshe1.Value = afzaiesh;
                File.WriteAllText(power, afzaiesh.ToString());

            }
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            if (File.Exists(power))
            {
                afzaiesh = int.Parse(File.ReadAllText(power));
                afzaieshe1.Value = afzaiesh;
            }
            else
            {
                afzaiesh = 0;
                File.WriteAllText(power, afzaiesh.ToString());
            }
            if (File.Exists(power1))
            {
                afzaiesh2 = int.Parse(File.ReadAllText(power1));
                progressBar1.Value = afzaiesh2;
            }
            else
            {
                afzaiesh2 = 0;
                File.WriteAllText(power1, afzaiesh2.ToString());
            }
            if (File.Exists(power2))
            {
                afzaiesh3 = int.Parse(File.ReadAllText(power2));
                progressBar2.Value = afzaiesh3;
            }
            else
            {
                afzaiesh3 = 0;
                File.WriteAllText(power2, afzaiesh3.ToString());
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                afzaiesh2 += 1;
                progressBar1.Value = afzaiesh2;
                File.WriteAllText(power1, afzaiesh2.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value < progressBar2.Maximum)
            {
                afzaiesh3 += 1;
                progressBar2.Value = afzaiesh3;
                File.WriteAllText(power2, afzaiesh3.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
           
            afzaiesh = 0;
            afzaiesh2 = 0;
            afzaiesh3 = 0;

       
            afzaieshe1.Value = 0;
            progressBar1.Value = 0;
            progressBar2.Value = 0;

   
            File.WriteAllText(power, "0");
            File.WriteAllText(power1, "0");
            File.WriteAllText(power2, "0");

            
           
        }

    }

}

