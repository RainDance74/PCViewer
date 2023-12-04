using System.Text;

namespace PCViewer.Core.Models
{
    public class Battery : BaseComponent
    {
        /// <summary>
        /// Вместимость батареи (указывается в ваттах в час, wh)
        /// </summary>
        public int Capacity { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(Capacity != 0) 
            {
                sb.AppendLine($"Вместимость баратеи: {Capacity}wh");
            }

            return sb.ToString();
        }
    }
}
