using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public abstract class StorageDevice : BaseComponent
    {
        /// <summary>
        /// Ресурс жизни накопителя (в террабайтах)
        /// </summary>
        public int LifeResource { get; set; }
        /// <summary>
        /// Вместимость накопителя (в гигабайтах)
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Скорость накопителя (в мегабайтах)
        /// </summary>
        public int Speed { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(LifeResource != 0)
            {
                sb.AppendLine($"Ресурс накопителя: {LifeResource}ТБ");
            }

            if(Capacity != 0)
            {
                sb.AppendLine($"Вместимость накопителя: {Capacity}ГБ");
            }

            if(Speed != 0)
            {
                sb.AppendLine($"Скорость чтения накопителя: {Speed}МБ");
            }

            return sb.ToString();
        }
    }
}
