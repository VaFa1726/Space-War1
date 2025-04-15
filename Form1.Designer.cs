namespace yu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            vorody1 = new TextBox();
            vorody2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labeltimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerbazshdan = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Image = Properties.Resources.Untitled_11;
            label1.Location = new Point(321, 86);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 1;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Image = Properties.Resources.Untitled_1;
            label2.Location = new Point(321, 174);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // vorody1
            // 
            vorody1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            vorody1.Location = new Point(468, 86);
            vorody1.Name = "vorody1";
            vorody1.Size = new Size(189, 34);
            vorody1.TabIndex = 3;
            // 
            // vorody2
            // 
            vorody2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            vorody2.ForeColor = SystemColors.ScrollBar;
            vorody2.Location = new Point(468, 171);
            vorody2.Name = "vorody2";
            vorody2.Size = new Size(189, 34);
            vorody2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(342, 310);
            button1.Name = "button1";
            button1.Size = new Size(99, 61);
            button1.TabIndex = 5;
            button1.Tag = "buttonform1";
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImage = Properties.Resources._2247249_big_copy;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(468, 310);
            button2.Name = "button2";
            button2.Size = new Size(99, 61);
            button2.TabIndex = 6;
            button2.Tag = "buttonform1";
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += pak;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImage = Properties.Resources._2247249_big_copy1;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(586, 310);
            button3.Name = "button3";
            button3.Size = new Size(99, 61);
            button3.TabIndex = 7;
            button3.Tag = "buttonform1";
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Khoroj;
            // 
            // labeltimer
            // 
            labeltimer.AutoSize = true;
            labeltimer.BackColor = SystemColors.ActiveCaptionText;
            labeltimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltimer.ForeColor = SystemColors.Window;
            labeltimer.Location = new Point(520, 3);
            labeltimer.Name = "labeltimer";
            labeltimer.Size = new Size(0, 38);
            labeltimer.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerbazshdan
            // 
            timerbazshdan.Interval = 10000;
            timerbazshdan.Tick += timerbazshdan_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 3);
            label3.Name = "label3";
            label3.Size = new Size(343, 38);
            label3.TabIndex = 10;
            label3.Text = "F1>username&&password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._2247249_big;
            ClientSize = new Size(695, 380);
            Controls.Add(label3);
            Controls.Add(labeltimer);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(vorody2);
            Controls.Add(vorody1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Location = new Point(10, 20);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox vorody1;
        private TextBox vorody2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label labeltimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerbazshdan;
        private System.Windows.Forms.Timer timer3;
        private Label label3;
    }
}
