using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoLst
    {
        private List<Task> todos;

        public ToDoLst(List<Task> todos)
        {
            this.todos = todos;
        }
        public ToDoLst()
        {
            
        }
    }
}
