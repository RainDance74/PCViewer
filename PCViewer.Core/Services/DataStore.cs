using PCViewer.Core.Contracts;
using PCViewer.Core.Helpers;
using PCViewer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCViewer.Core.Services
{
    public class DataStore<T> : IDataStore<T>
        where T : class
    {
        private readonly EntityCollection<T> _entities;

        public DataStore() 
        {
            _entities = new EntityCollection<T>();
        }

        public void Add(T elem)
        {
            _entities.Add(elem);
        }

        public void AddRange(IEnumerable<T> elems)
        {
            foreach(T elem in elems)
            {
                _entities.Add(elem);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public void Remove(T elem)
        {
            _entities.Remove(elem);
        }
    }
}
