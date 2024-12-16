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
<<<<<<< HEAD
            viewUsersButton.Location = new Point(309, 171);
=======
            viewUsersButton.Location = new Point(302, 193);
>>>>>>> d01a78aa0ad0e1566e2f46594d4eef25b87c269e
            viewUsersButton.Name = "viewUsersButton";
            viewUsersButton.Size = new Size(163, 86);
            viewUsersButton.TabIndex = 2;
            viewUsersButton.Text = "Edit projects";
            viewUsersButton.UseVisualStyleBackColor = false;
            viewUsersButton.Click += viewUsersButton_Click;
            // 
            // AddUsersButton
            // 
            AddUsersButton.BackColor = Color.Transparent;
            AddUsersButton.BackgroundImage = (Image)resources.GetObject("AddUsersButton.BackgroundImage");
            AddUsersButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUsersButton.ForeColor = Color.Black;
            AddUsersButton.ImageAlign = ContentAlignment.TopCenter;
<<<<<<< HEAD
            AddUsersButton.Location = new Point(75, 171);
=======
            AddUsersButton.Location = new Point(41, 193);
>>>>>>> d01a78aa0ad0e1566e2f46594d4eef25b87c269e
            AddUsersButton.Name = "AddUsersButton";
            AddUsersButton.Size = new Size(163, 86);
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
<<<<<<< HEAD
            AddProjectsButton.Location = new Point(531, 171);
=======
            AddProjectsButton.Location = new Point(574, 193);
>>>>>>> d01a78aa0ad0e1566e2f46594d4eef25b87c269e
            AddProjectsButton.Name = "AddProjectsButton";
            AddProjectsButton.Size = new Size(163, 86);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion
        private Button viewUsersButton;
        private PictureBox pictureBox1;
        private Button AddUsersButton;
        private Button AddProjectsButton;
    }
}