using System;
using System.Collections.Generic;
using System.Text;

namespace Servies
{
    public class TaskList
    {

        /// <summary>
        /// имя списка с задачами
        /// </summary>
        private String name { get; set; }


        /// <summary>
        /// список задач, относящихся к списку
        /// </summary>
        private List<Task> tasks { get; set; }



        /// <summary>
        /// Возвращение имени списка задач
        /// </summary>
        /// <returns></returns>
        public String Getname()
        {
            return name;
        }

        
        public Task AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public Task GetTasks()
        {
            return GetTasks();
        }


        /// <summary>
        /// имя со списком задач
        /// </summary>
        /// <param name="name"></param>
        public TaskList(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Удаляет щадачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            this.Remove(task);
        }
    }
}
