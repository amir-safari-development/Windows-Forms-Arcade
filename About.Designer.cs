namespace Arcade_Game
{
    partial class About
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 255, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(215, 48);
            textBox1.Margin = new Padding(3, 4, 3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 67);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            textBox1.Text = "Created By Amir Reza Safari & Sina Motamedi Nejad";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 255);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(480, 137);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 38);
            textBox2.TabIndex = 1;
            textBox2.Tag = "";
            textBox2.Text = "404521426";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(128, 255, 255);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(215, 137);
            textBox3.Margin = new Padding(0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 86);
            textBox3.TabIndex = 2;
            textBox3.Tag = "";
            textBox3.Text = " Student's Codes";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(128, 255, 255);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(480, 185);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 38);
            textBox4.TabIndex = 3;
            textBox4.Tag = "";
            textBox4.Text = "404522088";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightSkyBlue;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(54, 262);
            textBox5.Margin = new Padding(0);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(699, 144);
            textBox5.TabIndex = 4;
            textBox5.Tag = "";
            textBox5.Text = "                        Created by                                  Microsoft Visual Studio , SQLite DB ,      Pixart and generative Ais , C# & sfxr ";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6dbeae2d7f877e9b22b0e1d204037235;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "About";
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}