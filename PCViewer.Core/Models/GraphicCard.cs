namespace PCViewer.Core.Models
{
    public class GraphicCard : BaseComponent
    {
        /// <summary>
        /// Форм фактор видеокарты
        /// </summary>
        public string FormFactor { get; set; }
        /// <summary>
        /// Размер памяти видеокарты
        /// </summary>
        public int MemorySize { get; set; }
    }
}
