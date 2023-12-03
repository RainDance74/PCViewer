using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class PowerSupply : BaseComponent
    {
        /// <summary>
        /// Колличество ват
        /// </summary>
        public int Wattage { get; set; }
        /// <summary>
        /// Форм фактор размерности блока
        /// </summary>
        public string FormFactor { get; set; }
    }
}
