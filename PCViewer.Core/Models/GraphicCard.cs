using System.Text;

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

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(!string.IsNullOrEmpty(FormFactor))
            {
                sb.AppendLine($"Форм фактор: {FormFactor}");
            }

            if(MemorySize == 0)
            {
                sb.AppendLine("Размер памяти неизвестен, либо выделенен системой.");
            }
            else
            {
                sb.AppendLine($"Колличество памяти видеокарты: {MemorySize}");
            }

            return sb.ToString();
        }
    }
}
