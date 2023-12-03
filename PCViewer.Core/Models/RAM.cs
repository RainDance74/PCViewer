using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class RAM : BaseComponent
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int Speed { get; set; }
        public string FormFactor { get; set; }
    }
}
