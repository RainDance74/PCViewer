using System.Text;

namespace PCViewer.Core.Models
{
    public abstract class BaseComponent
    {
        /// <summary>
        /// Название модели компонента
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Бренд(компания) разработчика либо издателя компонента
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Цена компонента, указывается в рублях
        /// </summary>
        public int Cost { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            if(!string.IsNullOrEmpty(Model))
            {
                sb.AppendLine($"Модель: {Model}");
            }

            if(!string.IsNullOrEmpty(Brand))
            {
                sb.AppendLine($"Компания: {Brand}");
            }

            if(Cost == 0)
            {
                sb.AppendLine($"Цена неизвестна.");
            }
            else
            {
                sb.AppendLine($"Цена: {Cost}р");
            }

            return sb.ToString();
        }
    }
}
