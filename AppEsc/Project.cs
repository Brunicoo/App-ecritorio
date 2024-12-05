using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    internal class Project
    {
        static public List<Project> projects = new List<Project>();
        public String name;
        public String description;
        public enum ProjectState {toDo, inProgress, done};
        public ProjectState State { get; set; }
        public List<Task> tasks = new List<Task>();
        public DateTime startDate;
        public DateTime endDate;

        public void changeState(ProjectState newState)
        {
            this.State = newState;
        }
    }
}
