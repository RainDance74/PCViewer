namespace PCViewer.Core.Models
{
    public class Battery : BaseComponent
    {
        /// <summary>
        /// Вместимость батареи (указывается в ваттах в час, wh)
        /// </summary>
        public int Capacity { get; set; }
    }
}
