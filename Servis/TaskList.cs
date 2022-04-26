using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servis
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

        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
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


        /// <summary>
        /// Получает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            var today = DateTime.Now.ToShortDateString();
            var tasksByToday = tasks.Where(t => t.Due.ToShortDateString() == today).ToList();
            return tasksByToday;
        }

        /// <summary>
        /// Получает задачи запланированные на завтра в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            var today = DateTime.Now;
            var tasksByToday = tasks.Where(t => t.Due > today).ToList();
            return tasksByToday;




    }
    }
}
