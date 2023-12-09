using System;
using System.Collections;
using System.Collections.Generic;

namespace PCViewer.Core.Helpers
{
    public class EntityCollection<T> : IEnumerable<T>, ICollection<T>
        where T : class
    {
        private T[] _entities;

        public int Count => _entities.Length;

        public bool IsReadOnly => false;

        public EntityCollection() 
        {
            _entities = new T[0];
        }

        public void Add(T item)
        {
            var newArray = new T[_entities.Length + 1];
            Array.Copy(_entities, newArray, _entities.Length);
            newArray[newArray.Length - 1] = item;
            _entities = newArray;
        }

        public void Clear()
        {
            _entities = new T[0];
        }

        public bool Contains(T item)
        {
            foreach(var entity in _entities)
            {
                if(entity.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex = 0)
        {
            _entities.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            for(var i = 0; i < _entities.Length; i++)
            {
                if (_entities[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            var newArray = new T[_entities.Length - 1];
            var indexFound = false;

            for(var i = 0; i < _entities.Length; i++)
            {
                if(i == index)
                {
                    index = -1;
                    indexFound = true;
                    continue;
                }

                newArray[indexFound ? i - 1 : i] = _entities[i];
            }

            _entities = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T entity in _entities)
            {
                yield return entity;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _entities.GetEnumerator();
        }
    }
}
