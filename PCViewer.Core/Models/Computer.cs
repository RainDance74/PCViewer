using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Models
{
    public class Computer
    {
        /// <summary>
        /// Комплекты компонентов
        /// </summary>
        public List<ComponentComplect> Parts { get; set; }
        /// <summary>
        /// Цена компьютера
        /// </summary>
        public int Cost 
        { 
            get => Parts.Sum(p => p.ComplectCost); 
        }

        public Computer() 
        {
            Parts = new List<ComponentComplect>();
        }
    }
}
