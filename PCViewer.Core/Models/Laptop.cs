using System.Linq;
using System.Text;

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

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("-------------------------------------------");
            sb.AppendLine($"Суммарная цена ноутбука {Brand + " " + Model}: {Cost}р.");
            #region Характеристики
            if(!string.IsNullOrEmpty(Color))
            {
                sb.AppendLine($"Цвет ноутбука: {Color}");
            }

            if(Weight != 0.0f)
            {
                sb.AppendLine($"Вес ноутбука: {Weight}кг");
            }

            if(!string.IsNullOrEmpty(Description))
            {
                sb.AppendLine("-------");
                sb.AppendLine(Description);
                sb.AppendLine("-------");
            }
            #endregion
            sb.AppendLine();

            // TODO: Decompose to a method
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
