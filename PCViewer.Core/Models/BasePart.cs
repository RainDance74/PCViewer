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
    }
}
