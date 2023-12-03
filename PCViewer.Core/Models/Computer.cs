using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Models
{
    public class Computer
    {
        public List<ComponentComplect> Parts { get; set; }
        public int Cost 
        { 
            get => Parts.Sum(p => p.TotalCost); 
        }

        public Computer() 
        {
            Parts = new List<ComponentComplect>();
        }
    }
}
