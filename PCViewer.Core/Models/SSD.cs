using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class SSD : StorageDevice
    {
        /// <summary>
        /// Тип SSD
        /// </summary>
        public string Type { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if(!string.IsNullOrEmpty(Type))
            {
                sb.AppendLine($"Тип SSD: {Type}");
            }

            return sb.ToString();
        }
    }
}
