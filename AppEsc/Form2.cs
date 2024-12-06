﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterParent;

            this.Hide();
            form3.Show();
        }

        private void AddUsersButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.StartPosition = FormStartPosition.CenterParent;

            addUser.Show();
            this.Hide();
        }

        private void AddProjectsButton_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            createProject.StartPosition = FormStartPosition.CenterParent;

            createProject.Show();
            this.Hide();

        }
    }
}
