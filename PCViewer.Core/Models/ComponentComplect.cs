using System;
using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Models
{
    public abstract class ComponentComplect
    {
        public abstract int ComplectCost { get; set; }
    }

    public class ComponentComplect<T> : ComponentComplect
        where T : BaseComponent
    {
        private int _complectCost;
        public override int ComplectCost
        {
            get => _complectCost == 0 ? Values.Sum(v => v.Cost) : _complectCost;
            set => _complectCost = value;
        }
        public IEnumerable<T> Values { get; set; }

        public ComponentComplect(params T[] components)
        {
            Values = components;
        }

        public ComponentComplect(int complectCost, params T[] components)
        {
            Values = components;
            _complectCost = complectCost;
        }
    }
}
