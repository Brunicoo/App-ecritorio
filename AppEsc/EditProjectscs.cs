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
            String name = (String) viewProjectsListBox.SelectedItem;
            Project projectSelected = Project.projects.Find(p => p.name == name);

            foreach (var task in projectSelected.tasks)
            {
                if (task != null)
                {
                    viewTasksListBox.Items.Add("{Task name: " + task.taskname + "}");
                     foreach (var subtask in task.subTasks)
                    {
                        if (subtask != null)
                        {
                           viewTasksListBox.Items.Add("=> Subtask name: " + subtask.name);
                        } else 
                        {
                            viewTasksListBox.Items.Add("0 subtasks asigned");
                        }
                    }
                }
            }
            viewTasksListBox.Items.Add("-----------------------------------------------------------");
            viewTasksListBox.Font = new Font("Segoe UI", 15);
        }
    }
}
