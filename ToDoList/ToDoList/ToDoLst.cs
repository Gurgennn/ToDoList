using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoLst
    {
        private List<Task> todos;

        public ToDoLst(List<Task> todos)
        {
            if (todos == null)
            {
                throw new Exception("Invalid value");
            }
            this.todos = todos;
        }
        public ToDoLst()
        {
            todos = new List<Task>();
        }
        public void Add(Task task)
        {
            todos.Add(task);
        }
        public void Remove(Task task)
        {
            todos.Remove(task);
        }
        public void Remove(int i)
        {
            todos.RemoveAt(i);
        }
        public int RemoveAll(Predicate<Task> match)
        {
            return todos.RemoveAll(match);
        }
        public void Complete(int i)
        {
            todos[i].Completed = true;
        }
        public void CompleteAll(Predicate<Task> match)
        {
            for (int i = 0; i < todos.Count; i++)
            {

                if (match(todos[i]) == true)
                {
                    todos[i].Completed = true;
                }

            }
        }
    }
}
