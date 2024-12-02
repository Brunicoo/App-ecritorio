namespace AppEsc
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            groupBox1 = new GroupBox();
            CreateUser = new Button();
            NewPasswordTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            NewUserTextBox = new TextBox();
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
            groupBox1.Controls.Add(CreateUser);
            groupBox1.Controls.Add(NewPasswordTextBox);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(NewUserTextBox);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(180, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 419);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            // 
            // CreateUser
            // 
            CreateUser.Location = new Point(171, 353);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(84, 27);
            CreateUser.TabIndex = 6;
            CreateUser.Text = "Create user";
            CreateUser.UseVisualStyleBackColor = true;
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.Location = new Point(135, 297);
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.PasswordChar = '*';
            NewPasswordTextBox.PlaceholderText = "Introduce password";
            NewPasswordTextBox.Size = new Size(189, 23);
            NewPasswordTextBox.TabIndex = 4;
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
            // NewUserTextBox
            // 
            NewUserTextBox.Location = new Point(135, 218);
            NewUserTextBox.Name = "NewUserTextBox";
            NewUserTextBox.PlaceholderText = "Introduce user";
            NewUserTextBox.Size = new Size(189, 23);
            NewUserTextBox.TabIndex = 2;
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
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backInicio;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "SignUp";
            Text = "SignUp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CreateUser;
        private TextBox NewPasswordTextBox;
        private PictureBox pictureBox3;
        private TextBox NewUserTextBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}