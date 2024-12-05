using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    internal class Task
    {
        public String taskname;
        public DateTime startDate;
        public DateTime endDate;
        public enum TaskState {toDo, inProgress, done};
        public TaskState state;
        public List<SubTask> subTasks;
        public List<User> collaborators = new List<User>();

        public void changeTaskState(TaskState newState)
        {
            this.state = newState;
        }
    }
}
