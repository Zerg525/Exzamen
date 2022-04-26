using System;
using System.Collections.Generic;
using System.Text;

namespace Servis
{
    public class Application
    {

        /// <summary>
        /// Ссылка на единственный экземпляр класса
        /// </summary>
        private Application application { get; set; }

        /// <summary>
        /// список со списком задач
        /// </summary>
        private List<TaskList> taskLists { get; set; }


        /// <summary>
        /// ссылка на новый экземпляр
        /// </summary>
        private Application()
        {
            taskLists = new List<TaskList>();
        }

       
        /// <summary>
        /// Возвращает ссылку на экземпляр приложения
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application == null)
            {
                return new Application();
            }

            return application;
        }

    }
}
