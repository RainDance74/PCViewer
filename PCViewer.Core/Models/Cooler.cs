using System.Text;

namespace PCViewer.Core.Models
{
    public class Cooler : BaseComponent
    {
        /// <summary>
        /// Рассеиваемая мощность
        /// </summary>
        public int TDP { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(TDP != 0)
            {
                sb.AppendLine($"Рассеиваемая мощность(TDP): {TDP}");
            }

            return sb.ToString();
        }
    }
}
