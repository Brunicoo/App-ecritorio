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
            viewUsersButton = new Button();
            viewprojectsButton = new Button();
            AddUsersButton = new Button();
            AddProjectsButton = new Button();
            SuspendLayout();
            // 
            // viewUsersButton
            // 
            viewUsersButton.BackColor = Color.Transparent;
            viewUsersButton.BackgroundImage = (Image)resources.GetObject("viewUsersButton.BackgroundImage");
            viewUsersButton.BackgroundImageLayout = ImageLayout.Stretch;
            viewUsersButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewUsersButton.ForeColor = Color.Black;
            viewUsersButton.Location = new Point(398, 127);
            viewUsersButton.Name = "viewUsersButton";
            viewUsersButton.Size = new Size(135, 64);
            viewUsersButton.TabIndex = 2;
            viewUsersButton.Text = "Edit projects";
            viewUsersButton.UseVisualStyleBackColor = false;
            viewUsersButton.Click += viewUsersButton_Click;
            // 
            // viewprojectsButton
            // 
            viewprojectsButton.BackColor = Color.Transparent;
            viewprojectsButton.BackgroundImage = (Image)resources.GetObject("viewprojectsButton.BackgroundImage");
            viewprojectsButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewprojectsButton.ForeColor = Color.Black;
            viewprojectsButton.ImageAlign = ContentAlignment.TopCenter;
            viewprojectsButton.Location = new Point(234, 127);
            viewprojectsButton.Name = "viewprojectsButton";
            viewprojectsButton.Size = new Size(140, 64);
            viewprojectsButton.TabIndex = 1;
            viewprojectsButton.Text = "View projects";
            viewprojectsButton.UseVisualStyleBackColor = false;
            // 
            // AddUsersButton
            // 
            AddUsersButton.BackColor = Color.Transparent;
            AddUsersButton.BackgroundImage = (Image)resources.GetObject("AddUsersButton.BackgroundImage");
            AddUsersButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUsersButton.ForeColor = Color.Black;
            AddUsersButton.ImageAlign = ContentAlignment.TopCenter;
            AddUsersButton.Location = new Point(234, 215);
            AddUsersButton.Name = "AddUsersButton";
            AddUsersButton.Size = new Size(140, 64);
            AddUsersButton.TabIndex = 4;
            AddUsersButton.Text = "Add users";
            AddUsersButton.UseVisualStyleBackColor = false;
            AddUsersButton.Click += AddUsersButton_Click;
            // 
            // AddProjectsButton
            // 
            AddProjectsButton.BackColor = Color.Transparent;
            AddProjectsButton.BackgroundImage = (Image)resources.GetObject("AddProjectsButton.BackgroundImage");
            AddProjectsButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProjectsButton.ForeColor = Color.Black;
            AddProjectsButton.ImageAlign = ContentAlignment.TopCenter;
            AddProjectsButton.Location = new Point(398, 215);
            AddProjectsButton.Name = "AddProjectsButton";
            AddProjectsButton.Size = new Size(140, 64);
            AddProjectsButton.TabIndex = 5;
            AddProjectsButton.Text = "Add projects";
            AddProjectsButton.UseVisualStyleBackColor = false;
            AddProjectsButton.Click += AddProjectsButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(AddProjectsButton);
            Controls.Add(AddUsersButton);
            Controls.Add(viewUsersButton);
            Controls.Add(viewprojectsButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "w";
            ResumeLayout(false);
        }

        #endregion
        private Button viewprojectsButton;
        private Button viewUsersButton;
        private PictureBox pictureBox1;
        private Button AddUsersButton;
        private Button AddProjectsButton;
    }
}