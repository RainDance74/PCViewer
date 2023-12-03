using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class Processor : BaseComponent
    {
        /// <summary>
        /// Сокет процессора
        /// </summary>
        public string Socket { get; set; }
        /// <summary>
        /// Базовая частота процессора
        /// </summary>
        public float Frequency { get; set; }
        /// <summary>
        /// Максимальная частота процессора
        /// </summary>
        public float MaxFrequency { get; set; }
        /// <summary>
        /// Колличество ядер
        /// </summary>
        public int CoreNumber { get; set; }
        /// <summary>
        /// Колличество потоков
        /// </summary>
        public int ThreadNumber { get; set; }
        /// <summary>
        /// Видеокарта встроенная в процессор
        /// </summary>
        public GraphicCard GraphicCard { get; set; }
    }
}
