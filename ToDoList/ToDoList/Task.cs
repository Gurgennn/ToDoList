using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class Task
    {
        private string taskdesc;
        private bool completeted;

        public bool Completeted { get => completeted; set => completeted = value; }

        public Task(string taskdesc, bool completeted)
        {
            this.taskdesc = taskdesc;
            this.Completeted = completeted;
        }
        public Task()
        {
        }
        
    }
}
