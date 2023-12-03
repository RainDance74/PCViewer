using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class HDD : StorageDevice
    {
        /// <summary>
        /// Скорость вращения вентилей
        /// </summary>
        public int SpinSpeed { get; set; }
    }
}
