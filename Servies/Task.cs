using System;
using System.Collections.Generic;
using System.Text;

namespace Servies
{
    public class Task
    {


        /// <summary>
        /// Название задачи
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Дата и время завершения задачи
        /// </summary>
        public DateTime Due { get; set; }

        /// <summary>
        /// отметка о выполнении
        /// </summary>
        public Boolean Done { get; set; }
    }
}
