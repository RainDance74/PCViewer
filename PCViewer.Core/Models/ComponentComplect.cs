using System;
using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Models
{
    public abstract class ComponentComplect
    {
        /// <summary>
        /// Цена комплекта компонентов
        /// </summary>
        public abstract int ComplectCost { get; set; }
    }

    public class ComponentComplect<T> : ComponentComplect
        where T : BaseComponent
    {
        /// <summary>
        /// Цельная цена комплекта
        /// </summary>
        private int _complectCost;
        /// <summary>
        /// Цена комплекта компонентов
        /// </summary>
        public override int ComplectCost
        {
            get => _complectCost == 0 ? Values.Sum(v => v.Cost) : _complectCost;
            set => _complectCost = value;
        }
        /// <summary>
        /// Список компонентов комплекта
        /// </summary>
        public IEnumerable<T> Values { get; set; }

        /// <summary>
        /// Создает комплект компонентов
        /// </summary>
        /// <param name="components"></param>
        public ComponentComplect(params T[] components)
        {
            Values = components;
        }

        /// <summary>
        /// Создает комплект компонентов
        /// </summary>
        /// <param name="complectCost">
        /// Цена комплекта компонентов
        /// </param>
        /// <param name="components"></param>
        public ComponentComplect(int complectCost, params T[] components)
        {
            Values = components;
            _complectCost = complectCost;
        }
    }
}
