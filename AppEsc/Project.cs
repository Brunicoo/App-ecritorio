using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppEsc
{
    public class Project
    {
        static public List<Project> projects = new List<Project>();
        public String name {  get; set; }
        public String description { get; set; }
        public enum ProjectState {toDo, inProgress, done};

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProjectState State { get; set; }
        public List<Task> tasks { get; set; } = new List<Task>();
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public void changeState(ProjectState newState)
        {
            this.State = newState;
        }
    }
}
