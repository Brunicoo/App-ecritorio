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
        private Task t;
        public ChangeProject(Project p)
        {
            InitializeComponent();
            this.project = p;
            addCollabsToList();
            changeLabel();
            showTasks();
            dataGridViewTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.MultiSelect = false;
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
            dataGridViewTasks.Rows.Clear();
            foreach (var task in project.tasks)
            {
                string subtasks = "{" + string.Join(", ", task.subTasks.Select(sub => sub.name)) + "}";
                string col = "{" + string.Join(", ", task.collaborators.Select(c => c.userName)) + "}";

                dataGridViewTasks.Rows.Add(task.taskname, task.state, subtasks, col);
            }
        }

        private void addTask()
        {
            Task ta = new Task();
            ta.taskname = textTaskName.Text.Trim();
            ta.startDate = startDateTask.Value;
            ta.endDate = endDateTask.Value;
            ta.changeTaskState(Task.TaskState.toDo);

            foreach (String collaboratorName in checkedListBoxCollaborators.CheckedItems)
            {
                User selectedUser = User.users.Find(user => user.userName == collaboratorName);
                ta.collaborators.Add(selectedUser);
            }

            project.tasks.Add(ta);

            Tools.writeJsonProjects();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                textBoxSubtask.Clear();
                panel3.Visible = true;

                DataGridViewRow selectedRow = dataGridViewTasks.SelectedRows[0];
                String taskName = (String)selectedRow.Cells["taskNameColumn"].Value;

                t = project.tasks.Find(t => t.taskname == taskName);
            }
            else
            {
                MessageBox.Show("Please select a row.", "WARNING", MessageBoxButtons.OK);
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(139, 28);
            addCollabsToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                panelChangeCollaborators.Visible = true;
                panelChangeCollaborators.Location = new Point(505, 114);
                checkedListBoxCol.Items.Clear();

                DataGridViewRow selectedRow = dataGridViewTasks.SelectedRows[0];
                String taskName = (String)selectedRow.Cells["taskNameColumn"].Value;


                t = project.tasks.Find(t => t.taskname == taskName);

                foreach (var c in User.users)
                {
                    checkedListBoxCol.Items.Add(c.userName);
                    int index = checkedListBoxCol.Items.IndexOf(c.userName);

                    if (t.collaborators.Contains(c))
                    {
                        checkedListBoxCol.SetItemChecked(index, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.", "WARNING", MessageBoxButtons.OK);
            }
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
            checkedListBoxCollaborators.Items.Clear();

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Tools.openNewForm(this, f);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelChangeCollaborators.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCol.CheckedItems.Count == 0)
            {
                MessageBox.Show("The project has to have any collaborator", "WARNING", MessageBoxButtons.OK);

            }
            else
            {
                t.collaborators.Clear();

                foreach (var u in checkedListBoxCol.CheckedItems)
                {
                    String userName = (String)u;
                    User user = User.users.Find(us => us.userName == userName);

                    t.collaborators.Add(user);
                }
                MessageBox.Show("Update succesful!", "SUCCES", MessageBoxButtons.OK);
                showTasks();
                panelChangeCollaborators.Visible = false;

                Tools.writeJsonProjects();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBoxSubtask.Text == "")
            {
                MessageBox.Show("You must write a subtask name", "WARNING", MessageBoxButtons.OK);
            } else
            {
                SubTask s = new SubTask();
                s.name = textBoxSubtask.Text;
                s.startDate = dateTimePicker8.Value;
                s.endDate = dateTimePicker8.Value;

                t.subTasks.Add(s);
                MessageBox.Show("Subtask added!", "SUCCES", MessageBoxButtons.OK);
                showTasks();
                panel3.Visible = false;

                Tools.writeJsonProjects();
            }
        }
    }
}
