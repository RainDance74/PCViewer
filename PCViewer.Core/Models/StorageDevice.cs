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
    }
}
