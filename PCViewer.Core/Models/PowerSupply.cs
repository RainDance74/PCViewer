using System;
using System.Collections.Generic;
using System.Text;

namespace PCViewer.Core.Models
{
    public class PowerSupply : BaseComponent
    {
        public int Wattage { get; set; }
        public string FormFactor { get; set; }
    }
}
