using System;
using System.Collections.Generic;
using System.Text;

namespace Servies
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





    }
}
