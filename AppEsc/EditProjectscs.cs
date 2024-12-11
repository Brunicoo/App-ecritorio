using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEsc
{
    public partial class EditProjectscs : Form
    {
        public EditProjectscs()
        {
            InitializeComponent();
            showProjects();
        }

        private void viewProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTasks();
        }

        private void showProjects()
        {
            viewProjectsListBox.Items.Clear();
            foreach (var project in Project.projects)
            {
                if (project != null)
                {
                    viewProjectsListBox.Items.Add(project.name);
                }

            }
            viewProjectsListBox.Font = new Font("Segoe UI", 20);
        }

        private void showTasks()
        {
            viewTasksListBox.Items.Clear();
            String name = (String)viewProjectsListBox.SelectedItem;

            Project projectSelected = Project.projects.Find(p => p.name == name);
            if (projectSelected == null)
            {
                viewTasksListBox.Items.Add("0 projects selected");
                return;
            }

            foreach (var task in projectSelected.tasks)
            {
                if (task != null)
                {
                    viewTasksListBox.Items.Add("{Task name: " + task.taskname + " || " + task.state + "}");
                    foreach (var subtask in task.subTasks)
                    {
                        if (subtask == null)
                        {
                            viewTasksListBox.Items.Add("0 subtasks assigned");         
                        }
                        else
                        {
                            viewTasksListBox.Items.Add("=> Subtask name: " + subtask.name);
                        }
                    }
                }
            }
            viewTasksListBox.Items.Add("-----------------------------------------------------------");
            viewTasksListBox.Font = new Font("Segoe UI", 15);
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Tools.openNewForm(this, f2);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Project projectSelected;
            String projectName;

            if (viewProjectsListBox.SelectedItem == null)
            {
                MessageBox.Show("You must select a project", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                projectName = viewProjectsListBox.SelectedItem.ToString();
                projectSelected = Project.projects.Find(p => p.name == projectName);

                ChangeProject c = new ChangeProject(projectSelected);
                Tools.openNewForm(this, c);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Project projectSelected;
            String projectName;

            if (viewProjectsListBox.SelectedItem == null)
            {
                MessageBox.Show("You must select a project", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                projectName = viewProjectsListBox.SelectedItem.ToString();
                projectSelected = Project.projects.Find(p => p.name == projectName);

                Project.projects.Remove(projectSelected);
                viewProjectsListBox.Items.Remove(projectName);
                MessageBox.Show("Project deleted", "SUCCESS", MessageBoxButtons.OK);

                showProjects();
            }
        }

    }
}
