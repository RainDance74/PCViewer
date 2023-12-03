using System;
using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Models
{
    public abstract class ComponentComplect
    {
        public abstract int TotalCost { get; }
    }

    public class ComponentComplect<T> : ComponentComplect
        where T : BaseComponent
    {
        public override int TotalCost => Values.Sum(v => v.Cost);
        public IEnumerable<T> Values { get; set; }

        public ComponentComplect(params T[] components)
        {
            Values = components;
        }
    }
}
