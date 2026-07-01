namespace Arcade_Game
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            startGame = new Button();
            Shop = new Button();
            about = new Button();
            Exit = new Button();
            option = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startGame
            // 
            startGame.BackColor = SystemColors.ControlDark;
            startGame.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGame.Location = new Point(353, 134);
            startGame.Name = "startGame";
            startGame.Size = new Size(116, 46);
            startGame.TabIndex = 0;
            startGame.Text = "Start";
            startGame.UseVisualStyleBackColor = false;
            startGame.Click += btnStart_Click;
            // 
            // Shop
            // 
            Shop.BackColor = SystemColors.ControlDark;
            Shop.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Shop.Location = new Point(353, 196);
            Shop.Name = "Shop";
            Shop.Size = new Size(116, 46);
            Shop.TabIndex = 1;
            Shop.Text = "Shop";
            Shop.UseVisualStyleBackColor = false;
            // 
            // about
            // 
            about.BackColor = SystemColors.ControlDark;
            about.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            about.Location = new Point(353, 257);
            about.Name = "about";
            about.Size = new Size(116, 46);
            about.TabIndex = 2;
            about.Text = "About";
            about.UseVisualStyleBackColor = false;
            about.Click += about_Click;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ControlDark;
            Exit.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(353, 383);
            Exit.Name = "Exit";
            Exit.Size = new Size(116, 46);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // option
            // 
            option.BackColor = SystemColors.ControlDark;
            option.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            option.Location = new Point(353, 320);
            option.Name = "option";
            option.Size = new Size(116, 46);
            option.TabIndex = 4;
            option.Text = "Option";
            option.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.gameTitle;
            pictureBox1.Location = new Point(95, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(option);
            Controls.Add(Exit);
            Controls.Add(about);
            Controls.Add(Shop);
            Controls.Add(startGame);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuForm";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startGame;
        private Button Shop;
        private Button about;
        private Button Exit;
        private Button option;
        private PictureBox pictureBox1;
    }
}