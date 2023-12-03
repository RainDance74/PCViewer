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
    }
}
