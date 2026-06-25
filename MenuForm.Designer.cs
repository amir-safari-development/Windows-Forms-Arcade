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
            startGame = new Button();
            Shop = new Button();
            about = new Button();
            Exit = new Button();
            option = new Button();
            SuspendLayout();
            // 
            // startGame
            // 
            startGame.BackColor = SystemColors.ControlDark;
            startGame.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGame.Location = new Point(353, 36);
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
            Shop.Location = new Point(353, 121);
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
            about.Location = new Point(353, 203);
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
            Exit.Location = new Point(353, 369);
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
            option.Location = new Point(353, 289);
            option.Name = "option";
            option.Size = new Size(116, 46);
            option.TabIndex = 4;
            option.Text = "Option";
            option.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 450);
            Controls.Add(option);
            Controls.Add(Exit);
            Controls.Add(about);
            Controls.Add(Shop);
            Controls.Add(startGame);
            Name = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startGame;
        private Button Shop;
        private Button about;
        private Button Exit;
        private Button option;
    }
}