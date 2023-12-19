using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class HDD : StorageDevice
    {
        /// <summary>
        /// Скорость вращения вентилей (обороты в минуту)
        /// </summary>
        public int SpinSpeed { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if (SpinSpeed != 0)
            {
                sb.AppendLine($"Скорость вращения вентилей: {SpinSpeed} об/мин");
            }

            return sb.ToString();
        }
    }
}
