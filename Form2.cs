using Microsoft.VisualBasic;
using System;
using System.Data.SqlTypes;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yu
{
    public partial class Form2 : Form
    {

        private Form1 mainForm;
        public int heartenemy = 1;
        public int jampolharoilabal = 0;
        bool tan = true;
        string number = "";
        bool donafre = false;
        public string namekarbar = "namekarbar.txt";



        public Form2(Form1 form1)
        {
            InitializeComponent();
            labeltagirname.Text = File.ReadAllText("namekarbar.txt");
            mainForm = form1;

            LoadPool();
            label6.Text = number;
            label6.Text = number.ToString();
            vorodypassword.PasswordChar = '*';
            load();
            labelporofail.Text = File.ReadAllText("namekarbar.txt");
            label6.Text= File.ReadAllText("filepool.txt");
            e();

            this.KeyPreview = true;
        }


        private void LoadPool()
        {
            if (File.Exists("filepool.txt"))
            {
                string content = File.ReadAllText("filepool.txt");
                label6.Text = content;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tan == true)
            {
                button4.Visible = true;
                label1.Visible = true;
                buttondonafare.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
            }
            else
            {
                button4.Visible = false;
                label1.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                halategame.Visible = false;
                label4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            tan = !tan;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            buttondonafare.Visible = false;

            vorodyname.Visible = false;
            vorodypassword.Visible = false;
            passwordlabel.Visible = false;
            namwlabel.Visible = false;
            tanzimat.Visible = false;
            button3.Visible = false;
            if (vorodypassword.Text == "" || vorodyname.Text == "")
            {
                MessageBox.Show("Please enter your username and password correctly..");
                return;
            }

            string newUsername = vorodyname.Text;
            string newPassword = vorodypassword.Text;

            File.WriteAllText("name.txt", newUsername);
            File.WriteAllText("password.txt", newPassword);

            MessageBox.Show("New username and password saved.", "new password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Please enter your password:", "User Input", "Default Value");


            if (userInput == File.ReadAllText("password.txt"))
            {
                label1.Visible = false;
                button4.Visible = false;
                label4.Visible = false;
                buttondonafare.Visible = false;

                label2.Visible = false;
                label3.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button10.Visible = false;
                button9.Visible = false;
                halategame.Visible = false;
                MessageBox.Show("Password is correct.");
                vorodyname.Visible = true;
                vorodypassword.Visible = true;
                passwordlabel.Visible = true;
                namwlabel.Visible = true;
                tanzimat.Visible = true;
                button3.Visible = true;

            }
            else
            {
                MessageBox.Show("Incorrect password.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttondonafare.Visible = false;
            label1.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            button9.Visible = false;
            halategame.Visible = false;
            vorodyname.Visible = false;
            vorodypassword.Visible = false;
            passwordlabel.Visible = false;
            namwlabel.Visible = false;
            tanzimat.Visible = false;
            button3.Visible = false;
            Form4 frm2 = new Form4(this);
            frm2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            this.Hide();
        }
        public void jonenamy()
        {
            int num = heartenemy;
        }
        public void button7_Click(object sender, EventArgs e)
        {
            heartenemy = 1;
            buttondonafare.Visible = false;

            halategame.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            heartenemy = 2;
            buttondonafare.Visible = false;

            halategame.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            heartenemy = 3;
            buttondonafare.Visible = false;

            halategame.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tan = true;
            buttondonafare.Visible = false;
            label1.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            halategame.Visible = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttondonafare.Visible = false;
            button4.Visible = false;
            label1.Visible = false;

            button9.Visible = false;
            button10.Visible = false;
            halategame.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;

        }

        private void pictureBoxporifail_Click(object sender, EventArgs e)
        {
            labelgold.Text = File.ReadAllText("filepool.txt");
            labelporofail.Text = File.ReadAllText("namekarbar.txt");
            load();
            labelemtaz.Text = File.ReadAllText("filecore.txt");
            foreach (Control x in this.Controls)
            {
                if ((x is Label || x is PictureBox || x is System.Windows.Forms.Button) && x.Tag?.ToString() == "taghamash")


                {
                    x.Visible = false;
                }
            }
            label1000.Visible = true;
            label3000.Visible = true;
            label10000.Visible = true;
            label7.Visible = true;
            labelgold.Visible = true;
            pikcherboxporof1.Visible = true;
            pikcherboxporof2.Visible = true;
            pikcherboxporof3.Visible = true;
            labaelporofil.Visible = true;
            labelrecord.Visible = true;

            pictureBoxbraietaqirname.Visible = true;
            pictureBoxprrofaillabel.Visible = true;
            labelporofail.Visible = true;
            labaelporofil.Size = new Size(709, 497);
            labelemtaz.Visible = true;
            labaelporofil.BackColor = Color.LightGray;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if ((x is Label || x is PictureBox || x is System.Windows.Forms.Button) && x.Tag?.ToString() == "taghamash")
                {
                    x.Visible = true;
                }
            }
            labaelporofil.Visible = false;
            labelporofail.Visible = false;
            labelemtaz.Visible = false;
            pictureBoxprrofaillabel.Visible = false;

            pictureBoxbraietaqirname.Visible = false;
            pikcherboxporof1.Visible = false;
            pikcherboxporof2.Visible = false;
            pikcherboxporof3.Visible = false;
            labelrecord.Visible = false;
            label7.Visible = false;
            labelgold.Visible = false;

            label1000.Visible = false;
            label3000.Visible = false;
            label10000.Visible = false;
            label6.Text = File.ReadAllText("filepool.txt");
        }

        private void pictureBoxbraietaqirname_Click(object sender, EventArgs e)
        {

            string inpntname = Interaction.InputBox("enter your new name", "new name");
            int number = inpntname.Length;
            if (number <= 12)
            {
                File.WriteAllText("namekarbar.txt", inpntname);
                labelporofail.Text = inpntname;
                labeltagirname.Text = inpntname;
            }
            else
            {
                MessageBox.Show("error");
                return;

            }
        }
        private void load()
        {
            string name = File.ReadAllText("namekarbar.txt");
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            string savedAvatar = File.Exists("avatar.txt") ? File.ReadAllText("avatar.txt") : "";

            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                int userMoney = int.Parse(labelgold.Text);

                if (pictureBoxprrofaillabel.Image == clickedPictureBox.Image)
                {
                    MessageBox.Show("This image is already selected!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (clickedPictureBox == pikcherboxporof1)
                {
                    if (savedAvatar == "1")
                    {

                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 selected (already purchased)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (userMoney >= 1000)
                    {

                        pictureBoxasluporofail.Visible = true;
                        int num = userMoney - 1000;
                        label3000.Text = "Available";
                        File.WriteAllText("filepool.txt", num.ToString());
                        File.WriteAllText("avatar.txt", "1");
                        labelgold.Text = num.ToString();
                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 purchased and selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough coins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }
                if (clickedPictureBox == pikcherboxporof1)
                {
                    if (savedAvatar == "2")
                    {

                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 selected (already purchased)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (userMoney >= 3000)
                    {

                        pictureBoxasluporofail.Visible = true;
                        int num = userMoney - 3000;
                        File.WriteAllText("filepool.txt", num.ToString());
                        File.WriteAllText("avatar.txt", "1");
                        labelgold.Text = num.ToString();
                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 purchased and selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough coins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }
                if (clickedPictureBox == pikcherboxporof1)
                {
                    if (savedAvatar == "2")
                    {

                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 selected (already purchased)!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (userMoney >= 10000)
                    {

                        pictureBoxasluporofail.Visible = true;
                        int num = userMoney - 10000;
                        File.WriteAllText("filepool.txt", num.ToString());
                        File.WriteAllText("avatar.txt", "1");
                        labelgold.Text = num.ToString();
                        pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                        pictureBoxporifail.Image = clickedPictureBox.Image;
                        MessageBox.Show("Image 1 purchased and selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough coins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }


                if (clickedPictureBox == pikcherboxporof1 && userMoney >= 1000)
                {
                    pictureBoxasluporofail.Visible = true;

                    int num = userMoney - 1000;
                    File.WriteAllText("avatar.txt", "1");
                    File.WriteAllText("filepool.txt", num.ToString());
                    labelgold.Text = num.ToString();
                    pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                    pictureBoxporifail.Image = clickedPictureBox.Image;
                    MessageBox.Show("Image 1 selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (clickedPictureBox == pikcherboxporof2 && userMoney >= 3000)
                {
                    int num = userMoney - 3000;
                    pictureBoxasluporofail.Visible = true;
                    File.WriteAllText("avatar.txt", "2");
                    File.WriteAllText("filepool.txt", num.ToString());
                    labelgold.Text = num.ToString();
                    pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                    pictureBoxporifail.Image = clickedPictureBox.Image;
                    MessageBox.Show("Image 2 selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (clickedPictureBox == pikcherboxporof3 && userMoney >= 10000)
                {
                    pictureBoxasluporofail.Visible = true;

                    int num = userMoney - 10000;
                    File.WriteAllText("avatar.txt", "3");
                    File.WriteAllText("filepool.txt", num.ToString());
                    labelgold.Text = num.ToString();
                    pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                    pictureBoxporifail.Image = clickedPictureBox.Image;
                    MessageBox.Show("Image 3 selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (clickedPictureBox == pictureBoxasluporofail)
                {
                    pictureBoxasluporofail.Visible = false;
                    pictureBoxporifail.Image = clickedPictureBox.Image;
                    pictureBoxprrofaillabel.Image = clickedPictureBox.Image;
                }
                else
                {
                    MessageBox.Show("You don't have enough coins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void e()
        {

            pikcherboxporof1.Click += PictureBox_Click;
            pikcherboxporof2.Click += PictureBox_Click;
            pikcherboxporof3.Click += PictureBox_Click;
            pictureBoxasluporofail.Click += PictureBox_Click;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                label6.Text = File.ReadAllText("filepool.txt");
            }
        }

        private void buttondonafare_Click(object sender, EventArgs e)
        {
            modedonafre.donafare = true;
            buttondonafare.Visible = false;
            label1.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            button9.Visible = false;
            halategame.Visible = false;
            MessageBox.Show("The game has changed to two-player mode.", "two player", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static class modedonafre
        {

            public static bool donafare = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("filepool.txt", "0");
            label6.Text = "0";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (File.Exists("filepool.txt"))
            {
                string moneyText = File.ReadAllText("filepool.txt");
                labelgold.Text = moneyText;
            }

            if (File.Exists("avatar.txt"))
            {
                string avatarId = File.ReadAllText("avatar.txt");

                if (avatarId == "1")
                {
                    pictureBoxprrofaillabel.Image = pikcherboxporof1.Image;
                    pictureBoxporifail.Image = pikcherboxporof1.Image;
                }
                else if (avatarId == "2")
                {
                    pictureBoxprrofaillabel.Image = pikcherboxporof2.Image;
                    pictureBoxporifail.Image = pikcherboxporof2.Image;
                }
                else if (avatarId == "3")
                {
                    pictureBoxprrofaillabel.Image = pikcherboxporof3.Image;
                    pictureBoxporifail.Image = pikcherboxporof3.Image;
                }
            }
        }

        private void labelemtaz_Click(object sender, EventArgs e)
        {
            File.WriteAllText("avatar.txt", "43");
            File.WriteAllText("filepool.txt", "5000");
        }
    }
}



