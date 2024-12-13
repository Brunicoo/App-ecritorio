using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEsc
{
    public partial class ChangeProject : Form
    {
        private Project project;
        public ChangeProject(Project p)
        {
            InitializeComponent();
            this.project = p;
            addCollabsToList();
            changeLabel();
            showTasks();
        }

        private void ChangeProject_Load(object sender, EventArgs e)
        {

        }

        private void changeLabel()
        {
            labelTitle.Text = project.name;
        }

        private void showTasks()
        {
            foreach (var task in project.tasks)
            {
                string subtasks = "{" + string.Join(", ", task.subTasks.Select(sub => sub.name)) + "}";
                string col = "{" + string.Join(", ", task.collaborators.Select(c => c.userName)) + "}";

                dataGridViewTasks.Rows.Add(task.taskname, task.state, subtasks, col);
            }
        }

        private void addTask()
        {
            Task t = new Task();
            t.taskname = textTaskName.Text.Trim();
            t.startDate = startDateTask.Value;
            t.endDate = endDateTask.Value;
            t.changeTaskState(Task.TaskState.toDo);

            foreach (String collaboratorName in checkedListBoxCollaborators.CheckedItems)
            {
                User selectedUser = User.users.Find(user => user.userName == collaboratorName);
                t.collaborators.Add(selectedUser);
            }

            project.tasks.Add(t);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //añadir subtask
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addCollabsToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //añadir collab
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textTaskName.Text == "" || checkedListBoxCollaborators.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please complete all the fields", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                addTask();
                MessageBox.Show("Task added", "SUCCES", MessageBoxButtons.OK);
                revalidatePanel();
                showTasks();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            revalidatePanel();
        }
        private void addCollabsToList()
        {
            foreach (var user in User.users)
            {
                checkedListBoxCollaborators.Items.Add(user.userName);
            }
        }

        private void revalidatePanel()
        {
            textTaskName.Clear();
            checkedListBoxCollaborators.Items.Clear();
            panel1.Visible = false;
        }
    }
}
