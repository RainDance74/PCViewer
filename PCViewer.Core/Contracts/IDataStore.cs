using System;
using System.Collections.Generic;

namespace PCViewer.Core.Contracts
{
    public interface IDataStore<T>
        where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T elem);
        void AddRange(IEnumerable<T> elems);
        void Remove(T elem);
        void SortBy(Comparison<T> comparison);
        void Apply(Action<T> action);
        T First(Func<T, bool> predicate);
    }
}
