namespace AppEsc
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            groupBox1 = new GroupBox();
            backButton = new Button();
            createUserButton = new Button();
            newPasswordTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            newUserTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.grunge_fondo_azul;
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(backButton);
            groupBox1.Controls.Add(createUserButton);
            groupBox1.Controls.Add(newPasswordTextBox);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(newUserTextBox);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(180, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 419);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            // 
            // backButton
            // 
            backButton.Location = new Point(240, 354);
            backButton.Name = "backButton";
            backButton.Size = new Size(84, 27);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(75, 354);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(84, 27);
            createUserButton.TabIndex = 5;
            createUserButton.Text = "Create user";
            createUserButton.UseVisualStyleBackColor = true;
            createUserButton.Click += createUserButton_Click;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(135, 297);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.PlaceholderText = "Introduce password";
            newPasswordTextBox.Size = new Size(189, 23);
            newPasswordTextBox.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(75, 279);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // newUserTextBox
            // 
            newUserTextBox.Location = new Point(135, 218);
            newUserTextBox.Name = "newUserTextBox";
            newUserTextBox.PlaceholderText = "Introduce user";
            newUserTextBox.Size = new Size(189, 23);
            newUserTextBox.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backInicio;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button signInButton;
        private TextBox newPasswordTextBox;
        private PictureBox pictureBox3;
        private TextBox newUserTextBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button createUserButton;
        private Button backButton;
    }
}