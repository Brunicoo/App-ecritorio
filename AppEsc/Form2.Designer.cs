﻿namespace AppEsc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonProfile = new Button();
            buttonProjects = new Button();
            SuspendLayout();
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Transparent;
            buttonProfile.BackgroundImage = (Image)resources.GetObject("buttonProfile.BackgroundImage");
            buttonProfile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProfile.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProfile.ForeColor = Color.Black;
            buttonProfile.Location = new Point(392, 12);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(87, 34);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = false;
            // 
            // buttonProjects
            // 
            buttonProjects.BackColor = Color.Transparent;
            buttonProjects.BackgroundImage = (Image)resources.GetObject("buttonProjects.BackgroundImage");
            buttonProjects.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProjects.ForeColor = Color.Black;
            buttonProjects.ImageAlign = ContentAlignment.TopCenter;
            buttonProjects.Location = new Point(299, 12);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(87, 34);
            buttonProjects.TabIndex = 1;
            buttonProjects.Text = "Projects";
            buttonProjects.UseVisualStyleBackColor = false;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProfile);
            Controls.Add(buttonProjects);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonProjects;
        private Button buttonProfile;
    }
}