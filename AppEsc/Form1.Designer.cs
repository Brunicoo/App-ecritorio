namespace AppEsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            signUpButton = new Button();
            signInButton = new Button();
            passwordTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            userTextBox = new TextBox();
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
            groupBox1.Controls.Add(signUpButton);
            groupBox1.Controls.Add(signInButton);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(userTextBox);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(203, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(240, 354);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(84, 27);
            signUpButton.TabIndex = 6;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = true;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(75, 354);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(84, 27);
            signInButton.TabIndex = 5;
            signInButton.Text = "Sign in";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(135, 297);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Introduce password";
            passwordTextBox.Size = new Size(189, 23);
            passwordTextBox.TabIndex = 4;
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
            // userTextBox
            // 
            userTextBox.Location = new Point(135, 218);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Introduce user";
            userTextBox.Size = new Size(189, 23);
            userTextBox.TabIndex = 2;
            userTextBox.TextChanged += userTextBox_TextChanged;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backInicio;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox userTextBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button signUpButton;
        private Button signInButton;
        private TextBox passwordTextBox;
        private PictureBox pictureBox3;
    }
}
