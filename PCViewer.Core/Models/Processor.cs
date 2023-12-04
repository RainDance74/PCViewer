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

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(!string.IsNullOrEmpty(Socket))
            {
                sb.AppendLine($"Сокет: {Socket}");
            }

            if(Frequency != 0.0f)
            {
                sb.AppendLine($"Базовая частота работы: {Frequency}ГГц");
            }

            if(MaxFrequency != 0.0f)
            {
                sb.AppendLine($"Максимальная частота работы: {Frequency}ГГц");
            }

            if(CoreNumber != 0) 
            {
                sb.AppendLine($"Колличество ядер: {CoreNumber}");
            }

            if(ThreadNumber != 0)
            {
                sb.AppendLine($"Колличество потоков: {ThreadNumber}");
            }

            if(GraphicCard != null)
            {
                sb.AppendLine();
                sb.AppendLine("Встроенная видеокарта:");
                sb.AppendLine("----------");
                sb.AppendLine(GraphicCard.ToString());
                sb.AppendLine("----------");
            }

            return sb.ToString();
        }
    }
}
