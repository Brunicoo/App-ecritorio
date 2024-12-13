

namespace AppEsc
{
    partial class ChangeProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeProject));
            labelTitle = new Label();
            button1 = new Button();
            addTaskButton = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            buttonAccept = new Button();
            endDateTask = new DateTimePicker();
            label5 = new Label();
            startDateTask = new DateTimePicker();
            label4 = new Label();
            checkedListBoxCollaborators = new CheckedListBox();
            label2 = new Label();
            textTaskName = new TextBox();
            label1 = new Label();
            dataGridViewTasks = new DataGridView();
            taskNameColumn = new DataGridViewTextBoxColumn();
            taskStateColumn = new DataGridViewTextBoxColumn();
            subtasksColumn = new DataGridViewTextBoxColumn();
            collaboratorsColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = SystemColors.ActiveCaption;
            labelTitle.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(192, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(391, 58);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "label1";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(641, 40);
            button1.Name = "button1";
            button1.Size = new Size(123, 31);
            button1.TabIndex = 1;
            button1.Text = "Ch.Collabor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addTaskButton
            // 
            addTaskButton.BackColor = SystemColors.Info;
            addTaskButton.Location = new Point(641, 3);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(123, 31);
            addTaskButton.TabIndex = 2;
            addTaskButton.Text = "Add a task";
            addTaskButton.UseVisualStyleBackColor = false;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(641, 77);
            button3.Name = "button3";
            button3.Size = new Size(123, 31);
            button3.TabIndex = 3;
            button3.Text = "Add a subtask";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonAccept);
            panel1.Controls.Add(endDateTask);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(startDateTask);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkedListBoxCollaborators);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textTaskName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(201, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 376);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(20, 345);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(274, 345);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(75, 23);
            buttonAccept.TabIndex = 19;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // endDateTask
            // 
            endDateTask.Location = new Point(102, 310);
            endDateTask.Name = "endDateTask";
            endDateTask.Size = new Size(200, 23);
            endDateTask.TabIndex = 18;
            // 
            // label5
            // 
            label5.Location = new Point(20, 312);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 17;
            label5.Text = "End date";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startDateTask
            // 
            startDateTask.Location = new Point(102, 273);
            startDateTask.Name = "startDateTask";
            startDateTask.Size = new Size(200, 23);
            startDateTask.TabIndex = 16;
            // 
            // label4
            // 
            label4.Location = new Point(20, 275);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 15;
            label4.Text = "Stard date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxCollaborators
            // 
            checkedListBoxCollaborators.FormattingEnabled = true;
            checkedListBoxCollaborators.Location = new Point(102, 92);
            checkedListBoxCollaborators.Name = "checkedListBoxCollaborators";
            checkedListBoxCollaborators.Size = new Size(180, 166);
            checkedListBoxCollaborators.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Collaborators";
            // 
            // textTaskName
            // 
            textTaskName.Location = new Point(86, 45);
            textTaskName.Name = "textTaskName";
            textTaskName.Size = new Size(256, 23);
            textTaskName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 48);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Task name";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { taskNameColumn, taskStateColumn, subtasksColumn, collaboratorsColumn });
            dataGridViewTasks.Location = new Point(71, 114);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.Size = new Size(618, 324);
            dataGridViewTasks.TabIndex = 21;
            // 
            // taskNameColumn
            // 
            taskNameColumn.Frozen = true;
            taskNameColumn.HeaderText = "Task name";
            taskNameColumn.Name = "taskNameColumn";
            taskNameColumn.ReadOnly = true;
            // 
            // taskStateColumn
            // 
            taskStateColumn.HeaderText = "Task state";
            taskStateColumn.Name = "taskStateColumn";
            taskStateColumn.ReadOnly = true;
            taskStateColumn.Resizable = DataGridViewTriState.False;
            // 
            // subtasksColumn
            // 
            subtasksColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtasksColumn.HeaderText = "Subtasks";
            subtasksColumn.Name = "subtasksColumn";
            subtasksColumn.ReadOnly = true;
            // 
            // collaboratorsColumn
            // 
            collaboratorsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            collaboratorsColumn.HeaderText = "Collaborators";
            collaboratorsColumn.Name = "collaboratorsColumn";
            collaboratorsColumn.ReadOnly = true;
            // 
            // ChangeProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(button3);
            Controls.Add(addTaskButton);
            Controls.Add(button1);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeProject";
            Text = "ChangeProject";
            Load += ChangeProject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Label labelTitle;
        private Button button1;
        private Button addTaskButton;
        private Button button3;
        private Panel panel1;
        private TextBox textTaskName;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxCollaborators;
        private Label label4;
        private DateTimePicker startDateTask;
        private Label label5;
        private DateTimePicker endDateTask;
        private Button buttonAccept;
        private Button button2;
        private DataGridView dataGridViewTasks;
        private DataGridViewTextBoxColumn taskNameColumn;
        private DataGridViewTextBoxColumn taskStateColumn;
        private DataGridViewTextBoxColumn subtasksColumn;
        private DataGridViewTextBoxColumn collaboratorsColumn;
    }
}