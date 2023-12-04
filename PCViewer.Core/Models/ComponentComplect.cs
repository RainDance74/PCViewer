using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCViewer.Core.Models
{
    public abstract class ComponentComplect
    {
        /// <summary>
        /// Цена комплекта компонентов
        /// </summary>
        public abstract int ComplectCost { get; set; }

        public abstract override string ToString();
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

        public override string ToString()
        {
            var sb = new StringBuilder("\n");

            var componentName = GetType().GenericTypeArguments.First().Name;
            

            sb.AppendLine($"Информация о {componentName}:");

            if(_complectCost != 0)
            {
                sb.AppendLine($"Суммарная цена комплекта: {_complectCost}");
            }
            else if(_complectCost == 0 && Values.Count() > 1)
            {
                sb.AppendLine($"Суммарная цена комплекта: {_complectCost}");
            }

            sb.AppendLine();

            foreach(var component in Values)
            {
                sb.AppendLine(component.ToString());
            }

            sb.AppendLine("-----------------------------------");

            return sb.ToString();
        }
    }
}
