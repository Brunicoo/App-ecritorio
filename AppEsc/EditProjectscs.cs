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

        }

        private void showProjects()
        {
            foreach (var project in Project.projects)
            {
                if (project != null)
                { 
                    viewProjectsListBox.Items.Add("Name: " + project.name + " // " + " End date: " + project.endDate);
                }
            }
            viewProjectsListBox.Font = new Font("Segoe UI", 10);
        }
    }
}
