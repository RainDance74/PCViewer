using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class Processor : BaseComponent
    {
        public string Socket { get; set; }
        public float Frequency { get; set; }
        public float MaxFrequency { get; set; }
        public int CoreNumber { get; set; }
        public int ThreadNumber { get; set; }
        public GraphicCard GraphicCard { get; set; }
    }
}
