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

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(Wattage == 0)
            {
                sb.AppendLine("Мощность неизвестна.");
            }
            else
            {
                sb.AppendLine($"Мощность: {Wattage}w");
            }

            if(!string.IsNullOrEmpty(FormFactor))
            {
                sb.AppendLine($"Форм фактор: {FormFactor}");
            }

            return sb.ToString();
        }
    }
}
