using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class RAM : BaseComponent
    {
        /// <summary>
        /// Объем плашки памяти
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Тип памяти
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Частота работы памяти процессора в мегагерцах
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Форм фактор (SO-DIMM/DIMM)
        /// </summary>
        public string FormFactor { get; set; }
    }
}
