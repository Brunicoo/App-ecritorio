using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppEsc
{
    public class Task
    {
        public String taskname { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public enum TaskState {toDo, inProgress, done};

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TaskState state { get; set; }
        public List<SubTask> subTasks { get; set; } = new List<SubTask>();
        public List<User> collaborators { get; set; } = new List<User>();

        public void changeTaskState(TaskState newState)
        {
            this.state = newState;
        }
    }
}
