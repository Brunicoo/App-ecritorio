namespace AppEsc
{
    partial class EditProjectscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProjectscs));
            viewProjectsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            viewTasksListBox = new ListBox();
            backButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // viewProjectsListBox
            // 
            viewProjectsListBox.BackColor = Color.LightCyan;
            viewProjectsListBox.ForeColor = SystemColors.ControlText;
            viewProjectsListBox.FormattingEnabled = true;
            viewProjectsListBox.ItemHeight = 15;
            viewProjectsListBox.Location = new Point(58, 59);
            viewProjectsListBox.Name = "viewProjectsListBox";
            viewProjectsListBox.Size = new Size(299, 379);
            viewProjectsListBox.TabIndex = 0;
            viewProjectsListBox.SelectedIndexChanged += viewProjectsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 34);
            label1.TabIndex = 1;
            label1.Text = "PROJECTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 9);
            label2.Name = "label2";
            label2.Size = new Size(324, 34);
            label2.TabIndex = 2;
            label2.Text = "TASKS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewTasksListBox
            // 
            viewTasksListBox.BackColor = Color.LightCyan;
            viewTasksListBox.ForeColor = SystemColors.ControlText;
            viewTasksListBox.FormattingEnabled = true;
            viewTasksListBox.ItemHeight = 15;
            viewTasksListBox.Location = new Point(414, 59);
            viewTasksListBox.Name = "viewTasksListBox";
            viewTasksListBox.Size = new Size(400, 379);
            viewTasksListBox.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.Location = new Point(33, 466);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 35);
            backButton.TabIndex = 4;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(540, 466);
            editButton.Name = "editButton";
            editButton.Size = new Size(105, 35);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(676, 466);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(96, 35);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditProjectscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 513);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(backButton);
            Controls.Add(viewTasksListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(viewProjectsListBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditProjectscs";
            ResumeLayout(false);
        }

        #endregion

        private ListBox viewProjectsListBox;
        private Label label1;
        private Label label2;
        private ListBox viewTasksListBox;
        private Button backButton;
        private Button editButton;
        private Button deleteButton;
    }
}