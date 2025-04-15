using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using static System.Windows.Forms.DataFormats;
using static yu.Form2;


namespace yu
{

    public partial class Form3 : Form
    {


        private Form2 mainForm;
        private Form4 form4;
        Random red = new Random();
        bool goleft, goright, showing, isover, iscolor, isgoleft2, isgoright2, isshoing2;
        bool nemaieshqalb = true;
        bool iscolorback;
        bool isGhostMode = false;
        bool isqol20;
        bool stop = true;
        bool isNight = false;
        public int playerspeed = 12;
        int enemeyspped = 4;
        int score;
        int bullespeed;
        int bullespeed2;
        int lives = 3;
        int enamy1HitCount = 0;
        int enamy2HitCount = 0;
        int enamy3HitCount = 0;
        public int pool;
        int liveqol = 5;
        int maxSpeed = 25;
        int bulletpower = 1;

        SoundPlayer sound = new SoundPlayer(@"E:\sound\ممد1.wav");
        SoundPlayer sound2=new SoundPlayer(@"E:\seda\sound1.wav");
        SoundPlayer sound3 = new SoundPlayer(@"E:\seda\bar.wav");



        private int enemyMaxHealth;
        int highScore = 0;
        public int num = 0;
        private int receivedNum;

        string filescore = "filecore.txt";
        public string filesavepool = "filepool.txt";
        public Form3(Form2 form2Instance)
        {
            InitializeComponent();
            mainForm = form2Instance;

            this.KeyPreview = true;
            raset();
            enemyMaxHealth = mainForm.heartenemy;
            labelspeed.Text = "Speed: " + enemeyspped.ToString();
            timerback.Tick += new EventHandler(chengecolor);
            timersanie1.Tick += new EventHandler(afzaiesheemtiaz);
            timerspeedeanmy.Tick += new EventHandler(afzaieshespeednenamy);
            progressBar1.ForeColor = Color.Red;

            explosion.Visible = false;
            timerenfejar.Start();

            explosion.BringToFront();
            timerenfejar.Interval = 300;
            timerenfejar.Tick += (s, e) => { explosion.Visible = false; timerenfejar.Stop(); };
            LoadHighScore();
            labelrekord.Text = highScore.ToString();
            timerpowerenamy.Start();
            timerpowerenamy.Tick += new EventHandler(powerenamy);
            mainForm = form2Instance;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = mainForm.Location;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 3 - 50,
                100
            );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
     
        }
        public static class mmd
        {
            public static int playerSpeed = 12; 
        }

        private void seda()
        {
            sound3.Play();

        }
        private void ShowExplosion(PictureBox enemy)
        { 
            explosion.Visible = true;
            explosion.Location = new Point(enemy.Left, enemy.Top);
            timerenfejar.Start();
        }
        private void SaveHighScore()
        {
            File.WriteAllText(filescore, highScore.ToString());
        }
        private void LoadHighScore()
        {
            if (File.Exists(filescore))
            {
                string scoreText = File.ReadAllText(filescore);
                int.TryParse(scoreText, out highScore);
            }
        }
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                isGhostMode = true;
                MessageBox.Show("Ghost Mode Activated!");
            }

            if (e.KeyCode == Keys.P)
            {
                isGhostMode = false;
                MessageBox.Show("Ghost Mode Deactivated!");
            }
            if (e.KeyCode == Keys.Enter)
            {
                raset();
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (modedonafre.donafare == true && e.KeyCode == Keys.A)
            {
                isgoleft2 = true;
            }
            if (modedonafre.donafare == true && e.KeyCode == Keys.D)
            {
                isgoright2 = true;
            }
            if (e.KeyCode==Keys.Z)
            {
                if (mainForm!=null)
                {
                    mainForm.Show();
                    this.Hide();
                } // 🚫 form3 is of type Form3, but Form2 needs Form1

            }
            //if (e.KeyCode == Keys.A)
            //{

            //    if (mainForm != null)
            //    {

            //        mainForm.Show();
            //        this.Hide();
            //        File.WriteAllText(filesavepool, pool.ToString());
            //    }
            //}
        }
        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (modedonafre.donafare == true && e.KeyCode == Keys.A)
            {
                isgoleft2 = false;
            }
            if (modedonafre.donafare == true && e.KeyCode == Keys.D)
            {
                isgoright2 = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Space && showing == false)
            {
                showing = true;
                bullt.Top = player.Top - 5;
                bullt.Left = player.Left + (player.Width / 2) - (bullt.Width / 2);

            }
            if (e.KeyCode == Keys.W && isshoing2 == false)
            {
                isshoing2 = true;
                bulte2.Top = plyaer2.Top - 5;
                bulte2.Left = plyaer2.Left + (plyaer2.Width / 2) - (bulte2.Width / 2);
            }
        }

        private void badaneaslybazi_Tick(object sender, EventArgs e)
        {

            MovePlayer();
            MoveBullet();
            enamy();
            qalb();
            strt();
            mivebulte2();


        }


        private void MovePlayer()
        {
            if (goleft && player.Left > 0)
            {
                player.Left -= playerspeed;
            }
            if (goright && player.Right < this.ClientSize.Width)
            {
                player.Left += playerspeed;
            }
            if (isgoleft2 && plyaer2.Left > 0)
            {
                plyaer2.Left -= playerspeed;
            }
            if (isgoright2 && plyaer2.Right < this.ClientSize.Width)
            {
                plyaer2.Left += playerspeed;
            }
        }
        private void mivebulte2()
        {
            if (isshoing2)
            {
                bullespeed2 = 40;
                bulte2.Top -= bullespeed2;
            }
            else
            {
                bulte2.Left = -300;
                bullespeed2 = 0;
            }

            if (bulte2.Top < -30)
            {
                isshoing2 = false;
            }
        }
        private void MoveBullet()
        {
            if (showing)
            {
                bullespeed = 40;
                bullt.Top -= bullespeed;
            }
            else
            {
                bullt.Left = -300;
                bullespeed = 0;
            }

            if (bullt.Top < -30)
            {
                showing = false;
            }
        }
        //private void speedeanmys()
        //{
        //    if (score % 5 == 0 && score != 0)
        //    {
        //        if (enemeyspped<=10)
        //        {
        //           enemeyspped += 1;
        //        }

        //    }
        //}
        private void kamshodanescore()
        {
            score -= 3;
            scorelabel.Text = score.ToString();
        }
        private void qalb()
        {
            enerzhy.Top += 4;
            if (enerzhy.Top > this.ClientSize.Height)
            {
                enerzhy.Left = red.Next(20, this.ClientSize.Width - enerzhy.Width);
                enerzhy.Top = -red.Next(450, 650);
            }
            pictureBoxbulte.Top += 5;
            if (pictureBoxbulte.Top>this.ClientSize.Height)
            {
                enerzhy.Left = red.Next(20, this.ClientSize.Width - enerzhy.Width);
                enerzhy.Top = -red.Next(450, 1250);
            }

        }
        private void barkhordqalb()
        {

            if (enerzhy.Bounds.IntersectsWith(player.Bounds) || enerzhy.Bounds.IntersectsWith(plyaer2.Bounds))
            {

                enerzhy.Left = red.Next(20, this.ClientSize.Width - enerzhy.Width);
                enerzhy.Top = -red.Next(450, 650);
                if (progressBar1.Value < 5)
                {
                    progressBar1.Value += 1;
                }

            }
            if (pictureBoxbulte.Bounds.IntersectsWith(player.Bounds) || pictureBoxbulte.Bounds.IntersectsWith(plyaer2.Bounds))
            {

                pictureBoxbulte.Left = red.Next(20, this.ClientSize.Width - pictureBoxbulte.Width);
                pictureBoxbulte.Top = -red.Next(450, 1250);
                if (enemyMaxHealth>=2)
                {
                    enemyMaxHealth = 1;
                }

            }

        }

        private void UpdateScore()
        {


            if (score > highScore)
            {
                highScore = score;
                SaveHighScore();
            }
        }
        private void enamy()
        {

            enamy1.Top += enemeyspped;
            enamy2.Top += enemeyspped;
            enamy3.Top += enemeyspped;



            if (enamy1.Top > this.ClientSize.Height)
            {
                kamshodanescore();
                enamy1.Top = red.Next(100, 300) * -1;
                enamy1.Left = red.Next(20, this.ClientSize.Width - enamy1.Width);
            }

            if (enamy2.Top > this.ClientSize.Height)
            {
                kamshodanescore();
                enamy2.Top = red.Next(300, 500) * -1;
                enamy2.Left = red.Next(20, this.ClientSize.Width - enamy2.Width);
            }

            if (enamy3.Top > this.ClientSize.Height)
            {
                kamshodanescore();
                enamy3.Top = red.Next(500, 650) * -1;
                enamy3.Left = red.Next(20, this.ClientSize.Width - enamy3.Width);
            }

            //label7.Text = "Speed: " + enemeyspped.ToString();
            barkhordtir();
            baresy2();
            barkhordqalb();
        }


        private void barkhordtir()
        {
            if (isGhostMode == false)
            {
                if (enamy1.Bounds.IntersectsWith(player.Bounds) || enamy1.Bounds.IntersectsWith(plyaer2.Bounds))
                {

                    score -= 1;
                    if (progressBar1.Value > progressBar1.Minimum)
                    {
                        progressBar1.Value -= 1;
                    }

                    enamy1.Top = red.Next(100, 300) * -1;
                    enamy1.Left = red.Next(20, this.ClientSize.Width - enamy1.Width);
                }
                if (enamy2.Bounds.IntersectsWith(player.Bounds) || enamy2.Bounds.IntersectsWith(plyaer2.Bounds))
                {

                    score -= 1;
                    if (progressBar1.Value > progressBar1.Minimum)
                    {
                        progressBar1.Value -= 1;
                    }

                    enamy2.Top = red.Next(300, 500) * -1;
                    enamy2.Left = red.Next(20, this.ClientSize.Width - enamy2.Width);
                }
                if (enamy3.Bounds.IntersectsWith(player.Bounds) || enamy3.Bounds.IntersectsWith(plyaer2.Bounds))
                {
              

                    score -= 1;
                    if (progressBar1.Value > progressBar1.Minimum)
                    {
                        progressBar1.Value -= 1;
                    }

                    enamy3.Top = red.Next(500, 650) * -1;
                    enamy3.Left = red.Next(20, this.ClientSize.Width - enamy3.Width);
                }
                scorelabel.Text = score.ToString();
                if (progressBar1.Value == 0)
                {
                    gameover();
                }
            }
            if (isGhostMode == true)
            {

            }




        }

        private void baresy2()
        {

            if (bullt.Bounds.IntersectsWith(enamy1.Bounds) || bulte2.Bounds.IntersectsWith(enamy1.Bounds))
            {
                enamy1HitCount++;
                if (enamy1HitCount >= enemyMaxHealth)
                {
                    seda();
                    ShowExplosion(enamy1);
                    score += 2;
                    polplyar();
                    enamy1.Top = red.Next(100, 300) * -1;
                    enamy1.Left = red.Next(20, this.ClientSize.Width - enamy1.Width);
                    enamy1HitCount = 0;
                    scorelabel.Text = score.ToString();
                    IncreaseEnemySpeed();

                }
                showing = false;
                isshoing2 = false;
            }

            if (bullt.Bounds.IntersectsWith(enamy2.Bounds) || bulte2.Bounds.IntersectsWith(enamy2.Bounds))
            {
                enamy2HitCount++;
                if (enamy2HitCount >= enemyMaxHealth)
                {
                    seda();
                    ShowExplosion(enamy2);
                    polplyar();
                    score += 2;
                    enamy2.Top = red.Next(300, 500) * -1;
                    enamy2.Left = red.Next(20, this.ClientSize.Width - enamy2.Width);
                    enamy2HitCount = 0;
                    scorelabel.Text = score.ToString();
                    IncreaseEnemySpeed();
                }
                showing = false;
                isshoing2 = false;

            }

            if (bullt.Bounds.IntersectsWith(enamy3.Bounds) || bulte2.Bounds.IntersectsWith(enamy3.Bounds))
            {
                enamy3HitCount++;
                if (enamy3HitCount >= enemyMaxHealth)
                {
                    seda();
                    ShowExplosion(enamy3);
                    polplyar();
                    score += 2;
                    enamy3.Top = red.Next(500, 650) * -1;
                    enamy3.Left = red.Next(20, this.ClientSize.Width - enamy3.Width);
                    enamy3HitCount = 0;
                    scorelabel.Text = score.ToString();
                    IncreaseEnemySpeed();
                }
                showing = false;
                isshoing2 = false;

            }

        }



        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Close();
            }
        }
        private void labelchengecyan()
        {
            foreach (Control item in this.Controls)
            {
                if (item is System.Windows.Forms.Label && item.Tag != null && item.Tag.ToString() == "tabdilrang")
                {
                    item.ForeColor = Color.Black;
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "star")
                {
                    x.Visible = false;
                }
            }
        }
        private void labelblack()
        {
            foreach (Control item in this.Controls)
            {
                if (item is System.Windows.Forms.Label && item.Tag != null && item.Tag.ToString() == "tabdilrang")
                {
                    item.ForeColor = Color.White;
                }
            }
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "star")
                {
                    item.Visible = true;
                }
            }
        }
        private void chengecolor(object sender, EventArgs e)
        {
            if (iscolor)
            {
                labelchengecyan();
                this.BackColor = Color.Cyan;
            }
            else
            {
                labelblack();
                this.BackColor = Color.Black;

            }
            iscolor = !iscolor;
        }
        private void afzaiesheemtiaz(object sender, EventArgs e)
        {
            if (scorelabel.Text == "0")
            {
                scorelabel.Text = "";
            }
            score += 1;
            scorelabel.Text = score.ToString();
            UpdateScore();

        }
        private void powerenamy(object sender, EventArgs e)
        {
            enemyMaxHealth += 1;
        }
        private void afzaieshespeednenamy(object sender, EventArgs e)
        {
            enemeyspped = Math.Min(maxSpeed, enemeyspped + 1);
            sorat();
        }

        private void sorat()
        {

            labelspeed.Text = "Speed: " + enemeyspped.ToString();

        }
        private void polplyar()
        {
            int addedPool = 0;

            if (enemyMaxHealth == 1)
            {
                addedPool = 10;
                pool += 10;
            }
            else if (enemyMaxHealth == 2)
            {
                addedPool = 30;
                pool += 30;
            }
            else if (enemyMaxHealth == 3)
            {
                addedPool = 50;
                pool += 50;
            }
            else if (enemyMaxHealth >= 4)
            {
                addedPool = 60;
                pool += 60;
            }
            labelpol.Text = pool.ToString();

            int savedPool = 0;
            if (File.Exists(filesavepool))
            {
                string fileContent = File.ReadAllText(filesavepool);
                int.TryParse(fileContent, out savedPool);
            }

          
            int totalPool = savedPool + addedPool;

        
   


            File.WriteAllText(filesavepool, totalPool.ToString());
        }

        private void IncreaseEnemySpeed()
        {
            if (score % 5 == 0 && score != 0)
            {
                if (enemeyspped < maxSpeed)
                {
                    enemeyspped += 1;
                    labelspeed.Text = "Speed: " + enemeyspped.ToString();
                }
            }
        }

        public void save()
        {
            num = pool;

        }
        void strt()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "star")
                {
                    x.Top -= 5;
                    if (x.Top < 0)
                    {
                        x.Top = 800;
                    }
                }
            }
        }
        private void starttimeha()
        {
            badaneaslybazi.Start();
            timerback.Start();
            timersanie1.Start();
            timerspeedeanmy.Start();
        }
        private void meqdardahy()
        {
            progressBar1.Value = 5;
            enemeyspped = 4;
            playerspeed = 15;
            pool = 0;
            score = 0;
            bullt.Left = -300;
            bullespeed = 0;
            label2.Text = "";
            enemyMaxHealth = 1;
            scorelabel.Text = "0";
            labelpol.Text = "0";
        }
        private void left()
        {
          
            enamy1.Left = red.Next(20, this.ClientSize.Width - enamy1.Width);
            enamy2.Left = red.Next(20, this.ClientSize.Width - enamy2.Width);
            enamy3.Left = red.Next(20, this.ClientSize.Width - enamy3.Width);
            enerzhy.Left = red.Next(20, this.ClientSize.Width - enerzhy.Width);
            pictureBoxbulte.Left = red.Next(20, this.ClientSize.Width - pictureBoxbulte.Width);

        }
        private void top()
        {
            enamy1.Top = red.Next(100, 300) * -1;
            enamy2.Top = red.Next(300, 500) * -1;
            enamy3.Top = red.Next(500, 650) * -1;
            enerzhy.Top = red.Next(400, 1100) * -1;
            pictureBoxbulte.Top = red.Next(600, 1400) * -1;
        }
        private void raset()
        {

            starttimeha();
            meqdardahy();
            sorat();
            left();
            top();
            donofar();

            label5.Visible = false;
            label4.Visible = false;

        }
        private void meqdartatmam()
        {
            labelpol.Text = "0";
            labelspeed.Text = "Speed:" + "4";
            scorelabel.Text = "0";
            label2.Text = "Game over";

        }
        private void timerstop()
        {
            badaneaslybazi.Stop();
            timerback.Stop();
            timersanie1.Stop();
            timerspeedeanmy.Stop();
        }
        private void gameover()
        {
            label5.Visible = true;
            label4.Visible = true;
            meqdartatmam();
            timerstop();
            SaveHighScore();
            labelrekord.Text = (highScore.ToString());
            this.BackColor = Color.Black;
            labelpol.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            labelrekord.ForeColor = Color.White;
            labelspeed.ForeColor = Color.White;
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "star")
                {
                    item.Visible = true;
                }
            }
            scorelabel.ForeColor = Color.White;
          
        }

        private void clickbacktomenu(object sender, EventArgs e)
        {
            if (mainForm != null)
            {

                mainForm.StartPosition = FormStartPosition.Manual;
                mainForm.Location = this.Location;
                mainForm.Show();
                this.Hide();
                mainForm.Show();
                this.Hide();
                raset();
            }
        }

        private void clickstartgame(object sender, EventArgs e)
        {
            raset();
            label5.Visible = false;
            label4.Visible = false;
        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Close();
            }
        }
        private void spananemy5()
        {
            if (score % 20 == 0)
            {
                enamyqolll.Visible = true;
            }
        }
        public void SetImageToPictureBox(Image img)
        {
            player.Image = img;
        }
        public void imgebulltejet(Image jet)
        {
            bullt.Image = jet;
        }
        
        public void SetImageToBox(Image img)
        {
            pictureBox3.Image = img;
        }
        private void donofar()
        {
            if (modedonafre.donafare == true)
            {
                plyaer2.Left = 40;
                plyaer2.Visible = true;
                bulte2.Visible = true;

            }
            else
            {
                plyaer2.Left = -300;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            raset();
            labelpol.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            labelrekord.ForeColor = Color.White;
            labelspeed.ForeColor = Color.White;


            label4.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {

                mainForm.StartPosition = FormStartPosition.Manual;
                mainForm.Location = this.Location;
                mainForm.Show();
                this.Hide();
                mainForm.Show();
                this.Hide();
                raset();
            }
        }
    }
}
