using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    public class Task
    {
        public String taskname;
        public DateTime startDate;
        public DateTime endDate;
        public enum TaskState {toDo, inProgress, done};
        public TaskState state;
        public List<SubTask> subTasks = new List<SubTask>();
        public List<User> collaborators = new List<User>();

        public void changeTaskState(TaskState newState)
        {
            this.state = newState;
        }
    }
}
