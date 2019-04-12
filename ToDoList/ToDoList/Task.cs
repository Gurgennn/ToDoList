using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class Task
    {
        private string _taskDesc;
        private bool completed;
        public Task()
        {
        }
        public bool Completed { get;  set; }

        public Task(string taskdesc, bool completeted)
        {
            _taskDesc = taskdesc;
            this.Completed = completeted;
        }


    }
}
