namespace yu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            player1 = new Button();
            jet1 = new PictureBox();
            jet3 = new PictureBox();
            jet2 = new PictureBox();
            playerasly = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            afzaieshe1 = new ProgressBar();
            buttonafzaiesh = new Button();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            progressBar2 = new ProgressBar();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)jet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerasly).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            player1.Location = new Point(308, 21);
            player1.Name = "player1";
            player1.Size = new Size(161, 65);
            player1.TabIndex = 0;
            player1.Text = "Back";
            player1.UseVisualStyleBackColor = true;
            player1.Click += player1_Click;
            // 
            // jet1
            // 
            jet1.BackgroundImage = Properties.Resources.space_backgrounds_YVR2HR_7_result1;
            jet1.Image = Properties.Resources.ooooo_copy;
            jet1.Location = new Point(63, 383);
            jet1.Name = "jet1";
            jet1.Size = new Size(161, 132);
            jet1.SizeMode = PictureBoxSizeMode.StretchImage;
            jet1.TabIndex = 1;
            jet1.TabStop = false;
            // 
            // jet3
            // 
            jet3.BackgroundImage = Properties.Resources.space_backgrounds_YVR2HR_7_result2;
            jet3.Image = (Image)resources.GetObject("jet3.Image");
            jet3.Location = new Point(566, 383);
            jet3.Name = "jet3";
            jet3.Size = new Size(161, 132);
            jet3.SizeMode = PictureBoxSizeMode.StretchImage;
            jet3.TabIndex = 2;
            jet3.TabStop = false;
            // 
            // jet2
            // 
            jet2.BackgroundImage = Properties.Resources.space_backgrounds_YVR2HR_7_result;
            jet2.Image = (Image)resources.GetObject("jet2.Image");
            jet2.Location = new Point(296, 375);
            jet2.Name = "jet2";
            jet2.Size = new Size(183, 140);
            jet2.SizeMode = PictureBoxSizeMode.StretchImage;
            jet2.TabIndex = 3;
            jet2.TabStop = false;
            // 
            // playerasly
            // 
            playerasly.BackgroundImage = Properties.Resources.space_backgrounds_YVR2HR_7_result;
            playerasly.Image = (Image)resources.GetObject("playerasly.Image");
            playerasly.Location = new Point(296, 126);
            playerasly.Name = "playerasly";
            playerasly.Size = new Size(190, 168);
            playerasly.SizeMode = PictureBoxSizeMode.StretchImage;
            playerasly.TabIndex = 5;
            playerasly.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Image = Properties.Resources.space_backgrounds_YVR2HR_7_result3;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 41);
            label1.TabIndex = 6;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Image = Properties.Resources.space_backgrounds_YVR2HR_7_result3;
            label2.Location = new Point(90, 317);
            label2.Name = "label2";
            label2.Size = new Size(69, 41);
            label2.TabIndex = 7;
            label2.Text = "500";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Image = Properties.Resources.space_backgrounds_YVR2HR_7_result3;
            label3.Location = new Point(344, 317);
            label3.Name = "label3";
            label3.Size = new Size(86, 41);
            label3.TabIndex = 8;
            label3.Text = "1500";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Image = Properties.Resources.space_backgrounds_YVR2HR_7_result3;
            label4.Location = new Point(598, 317);
            label4.Name = "label4";
            label4.Size = new Size(86, 41);
            label4.TabIndex = 9;
            label4.Text = "3000";
            // 
            // afzaieshe1
            // 
            afzaieshe1.Location = new Point(63, 533);
            afzaieshe1.Maximum = 5;
            afzaieshe1.Name = "afzaieshe1";
            afzaieshe1.Size = new Size(161, 29);
            afzaieshe1.TabIndex = 10;
            // 
            // buttonafzaiesh
            // 
            buttonafzaiesh.BackColor = Color.DarkRed;
            buttonafzaiesh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonafzaiesh.Location = new Point(119, 568);
            buttonafzaiesh.Name = "buttonafzaiesh";
            buttonafzaiesh.Size = new Size(40, 38);
            buttonafzaiesh.TabIndex = 11;
            buttonafzaiesh.UseVisualStyleBackColor = false;
            buttonafzaiesh.Click += buttonafzaiesh_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(371, 568);
            button1.Name = "button1";
            button1.Size = new Size(40, 38);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(296, 533);
            progressBar1.Maximum = 8;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(183, 29);
            progressBar1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(626, 568);
            button2.Name = "button2";
            button2.Size = new Size(40, 38);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(566, 533);
            progressBar2.Maximum = 8;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(161, 29);
            progressBar2.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(761, 9);
            button3.Name = "button3";
            button3.Size = new Size(27, 29);
            button3.TabIndex = 16;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 625);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(progressBar2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(buttonafzaiesh);
            Controls.Add(afzaieshe1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(playerasly);
            Controls.Add(jet2);
            Controls.Add(jet3);
            Controls.Add(jet1);
            Controls.Add(player1);
            Location = new Point(50, 50);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            KeyDown += Form4_KeyDown;
            ((System.ComponentModel.ISupportInitialize)jet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet3).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerasly).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button player1;
        private PictureBox jet1;
        private PictureBox jet3;
        private PictureBox jet2;
        private PictureBox playerasly;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar afzaieshe1;
        private Button buttonafzaiesh;
        private Button button1;
        private ProgressBar progressBar1;
        private Button button2;
        private ProgressBar progressBar2;
        private Button button3;
    }
}