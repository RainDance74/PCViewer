using System.Text;

namespace PCViewer.Core.Models
{
    public class Motherboard : BaseComponent
    {
        /// <summary>
        /// Тип памяти поддерживающийся материнской платой
        /// </summary>
        public string MemoryType { get; set; }
        /// <summary>
        /// Тип сокета
        /// </summary>
        public string SocketType { get; set; }
        /// <summary>
        /// Чипсет материнской платы
        /// </summary>
        public string Chipset { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(!string.IsNullOrEmpty(MemoryType)) 
            {
                sb.AppendLine($"Тип поддерживающейся ОЗУ: {MemoryType}");
            }

            if(!string.IsNullOrEmpty(SocketType))
            {
                sb.AppendLine($"Сокет: {SocketType}");
            }

            if(!string.IsNullOrEmpty(Chipset))
            {
                sb.AppendLine($"Чипсет платы: {Chipset}");
            }

            return sb.ToString();
        }
    }
}
