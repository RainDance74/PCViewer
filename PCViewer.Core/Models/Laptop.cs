using System.Linq;

namespace PCViewer.Core.Models
{
    public class Laptop : Computer
    {
        private int _laptopCost;
        /// <summary>
        /// Название модели ноутбука
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Бренд выпустивший ноутбук
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Описание ноутбука
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Цвет ноутбука
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Вес ноутбука, указывается в килограммах
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// Суммарная цена ноутбука
        /// </summary>
        public new int Cost 
        {
            get => _laptopCost + Parts.Sum(p => p.ComplectCost); 
            set => _laptopCost = value; 
        }
    }
}
