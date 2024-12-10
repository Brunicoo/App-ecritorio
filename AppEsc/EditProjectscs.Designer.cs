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
            button1 = new Button();
            SuspendLayout();
            // 
            // viewProjectsListBox
            // 
            viewProjectsListBox.BackColor = Color.LightCyan;
            viewProjectsListBox.ForeColor = SystemColors.ControlText;
            viewProjectsListBox.FormattingEnabled = true;
            viewProjectsListBox.ItemHeight = 15;
            viewProjectsListBox.Location = new Point(33, 59);
            viewProjectsListBox.Name = "viewProjectsListBox";
            viewProjectsListBox.Size = new Size(324, 379);
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
            viewTasksListBox.Size = new Size(324, 379);
            viewTasksListBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            // 
            // EditProjectscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(viewTasksListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(viewProjectsListBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditProjectscs";
            Text = "EditProjectscs";
            ResumeLayout(false);
        }

        #endregion

        private ListBox viewProjectsListBox;
        private Label label1;
        private Label label2;
        private ListBox viewTasksListBox;
        private Button button1;
    }
}