using System.Linq;

namespace PCViewer.Core.Models
{
    public class Laptop : Computer
    {
        private int _laptopCost;
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public float Weight { get; set; }
        public new int Cost 
        {
            get => _laptopCost + Parts.Sum(p => p.TotalCost); 
            set => _laptopCost = value; 
        }
    }
}
