using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public abstract class StorageDevice : BaseComponent
    {
        public int LifeResource { get; set; }
        public int Capacity { get; set; }
        public int Speed { get; set; }
    }
}
