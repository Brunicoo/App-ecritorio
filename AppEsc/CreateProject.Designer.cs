namespace AppEsc
{
    partial class CreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProject));
            pictureBox1 = new PictureBox();
            projectNameTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            descriptionTextBox = new TextBox();
            createProjectButton = new Button();
            checkedListBoxCollaborators = new CheckedListBox();
            label1 = new Label();
            taskNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            endDateProject = new DateTimePicker();
            label4 = new Label();
            startDateProject = new DateTimePicker();
            startDateTask = new DateTimePicker();
            label5 = new Label();
            endDateTask = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.BackColor = Color.White;
            projectNameTextBox.ForeColor = SystemColors.MenuText;
            projectNameTextBox.Location = new Point(84, 78);
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.PlaceholderText = "Project name";
            projectNameTextBox.Size = new Size(266, 23);
            projectNameTextBox.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(84, 124);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "DESCRIPTION";
            descriptionTextBox.Size = new Size(266, 125);
            descriptionTextBox.TabIndex = 3;
            descriptionTextBox.TabStop = false;
            // 
            // createProjectButton
            // 
            createProjectButton.BackColor = Color.Transparent;
            createProjectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createProjectButton.ForeColor = Color.Black;
            createProjectButton.Location = new Point(84, 369);
            createProjectButton.Name = "createProjectButton";
            createProjectButton.Size = new Size(112, 30);
            createProjectButton.TabIndex = 6;
            createProjectButton.Text = "Create project";
            createProjectButton.UseVisualStyleBackColor = false;
            createProjectButton.Click += createProjectButton_Click;
            // 
            // checkedListBoxCollaborators
            // 
            checkedListBoxCollaborators.FormattingEnabled = true;
            checkedListBoxCollaborators.Location = new Point(410, 142);
            checkedListBoxCollaborators.Name = "checkedListBoxCollaborators";
            checkedListBoxCollaborators.Size = new Size(218, 94);
            checkedListBoxCollaborators.TabIndex = 7;
            checkedListBoxCollaborators.SelectedIndexChanged += checkedListBoxCollaborators_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 49);
            label1.Name = "label1";
            label1.Size = new Size(176, 52);
            label1.TabIndex = 8;
            label1.Text = "ADD A TASK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(410, 104);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.PlaceholderText = "Task name";
            taskNameTextBox.Size = new Size(218, 23);
            taskNameTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.Location = new Point(84, 268);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 11;
            label2.Text = "Stard date";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(84, 301);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 12;
            label3.Text = "End date";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endDateProject
            // 
            endDateProject.Location = new Point(150, 301);
            endDateProject.Name = "endDateProject";
            endDateProject.Size = new Size(200, 23);
            endDateProject.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(410, 256);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 14;
            label4.Text = "Stard date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startDateProject
            // 
            startDateProject.Location = new Point(150, 268);
            startDateProject.Name = "startDateProject";
            startDateProject.Size = new Size(200, 23);
            startDateProject.TabIndex = 10;
            // 
            // startDateTask
            // 
            startDateTask.Location = new Point(484, 256);
            startDateTask.Name = "startDateTask";
            startDateTask.Size = new Size(200, 23);
            startDateTask.TabIndex = 15;
            // 
            // label5
            // 
            label5.Location = new Point(410, 292);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 16;
            label5.Text = "End date";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endDateTask
            // 
            endDateTask.Location = new Point(484, 292);
            endDateTask.Name = "endDateTask";
            endDateTask.Size = new Size(200, 23);
            endDateTask.TabIndex = 17;
            // 
            // CreateProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backInicio;
            ClientSize = new Size(800, 450);
            Controls.Add(endDateTask);
            Controls.Add(label5);
            Controls.Add(startDateTask);
            Controls.Add(label4);
            Controls.Add(endDateProject);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(startDateProject);
            Controls.Add(taskNameTextBox);
            Controls.Add(label1);
            Controls.Add(checkedListBoxCollaborators);
            Controls.Add(createProjectButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(projectNameTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Project name";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox projectNameTextBox;
        private PictureBox pictureBox2;
        private TextBox descriptionTextBox;
        private Button createProjectButton;
        private CheckedListBox checkedListBoxCollaborators;
        private Label label1;
        private TextBox taskNameTextBox;
        private Label label2;
        private Label label3;
        private DateTimePicker endDateProject;
        private Label label4;
        private DateTimePicker startDateProject;
        private DateTimePicker startDateTask;
        private Label label5;
        private DateTimePicker endDateTask;
    }
}