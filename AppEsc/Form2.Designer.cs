namespace AppEsc
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
            groupBox1 = new GroupBox();
            buttonHome = new Button();
            buttonProjects = new Button();
            buttonProfile = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(buttonProfile);
            groupBox1.Controls.Add(buttonProjects);
            groupBox1.Controls.Add(buttonHome);
            groupBox1.Cursor = Cursors.SizeAll;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.BackgroundImage = (Image)resources.GetObject("buttonHome.BackgroundImage");
            buttonHome.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHome.ForeColor = SystemColors.ControlLightLight;
            buttonHome.Location = new Point(76, 12);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(87, 34);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            buttonProjects.BackgroundImage = (Image)resources.GetObject("buttonProjects.BackgroundImage");
            buttonProjects.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProjects.ForeColor = SystemColors.ControlLightLight;
            buttonProjects.Location = new Point(351, 12);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(87, 34);
            buttonProjects.TabIndex = 1;
            buttonProjects.Text = "Projects";
            buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            buttonProfile.BackgroundImage = (Image)resources.GetObject("buttonProfile.BackgroundImage");
            buttonProfile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProfile.ForeColor = SystemColors.ControlLightLight;
            buttonProfile.Location = new Point(625, 12);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(87, 34);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonProjects;
        private Button buttonHome;
        private Button buttonProfile;
    }
}