namespace Arcade_Game
{
    partial class choose
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
            NormMode = new Button();
            backBtn = new Button();
            PixMode = new Button();
            SuspendLayout();
            // 
            // NormMode
            // 
            NormMode.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NormMode.Location = new Point(502, 127);
            NormMode.Name = "NormMode";
            NormMode.Size = new Size(188, 80);
            NormMode.TabIndex = 0;
            NormMode.Text = "Normal Mode";
            NormMode.UseVisualStyleBackColor = true;
            NormMode.Click += NormMode_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.SpringGreen;
            backBtn.Font = new Font("Lucida Console", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.ActiveCaptionText;
            backBtn.Location = new Point(324, 280);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(167, 60);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // PixMode
            // 
            PixMode.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PixMode.Location = new Point(125, 127);
            PixMode.Name = "PixMode";
            PixMode.Size = new Size(188, 80);
            PixMode.TabIndex = 2;
            PixMode.Text = "Pixel Mode";
            PixMode.UseVisualStyleBackColor = true;
            // 
            // choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6dbeae2d7f877e9b22b0e1d204037235;
            ClientSize = new Size(800, 450);
            Controls.Add(PixMode);
            Controls.Add(backBtn);
            Controls.Add(NormMode);
            MinimizeBox = false;
            Name = "choose";
            Text = "choose";
            ResumeLayout(false);
        }

        #endregion

        private Button NormMode;
        private Button backBtn;
        private Button PixMode;
    }
}