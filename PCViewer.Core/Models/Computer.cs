using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCViewer.Core.Models
{
    public class Computer
    {
        /// <summary>
        /// Комплекты компонентов
        /// </summary>
        public List<ComponentComplect> Parts { get; set; }
        /// <summary>
        /// Цена компьютера в рублях
        /// </summary>
        public int Cost 
        { 
            get => Parts.Sum(p => p.ComplectCost); 
        }

        public Computer() 
        {
            Parts = new List<ComponentComplect>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("-------------------------------------------");
            sb.AppendLine($"Суммарная цена данного компьютера {Cost}р.");
            sb.AppendLine(GetPartsText());

            return sb.ToString();
        }

        protected string GetPartsText()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Информация о комплектующих предоставлена ниже.");
            sb.AppendLine();

            foreach(var complect in Parts)
            {
                sb.AppendLine(complect.ToString());
            }

            return sb.ToString();
        }
    }
}
