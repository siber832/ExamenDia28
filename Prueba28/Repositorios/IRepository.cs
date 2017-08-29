using System;
using System.Collections.Generic;
using System.Linq;
using Prueba28.Factorias;

namespace Prueba28
{
    public abstract class IRepository
    {
        public Dictionary<Object, Object> Elements { get; set; }
        public IFactoriaObjetos Factoria { get; set; }

        public void Add(Object key, Object element)
        {
            Elements.Add(key, element);
        }

        public abstract void Commit();

        public Object Get(Object key)
        {
            Object value;
            Elements.TryGetValue(key, out value);
            return value;
        }

        public IEnumerable<Object> GetAll()
        {
            return Elements.Values.ToList();
        }

        public abstract void Initizalize();

        public abstract Object RecuperateParticular(Object key);

        public void Remove(Object key)
        {
            Elements.Remove(key);
        }

        public void Update(Object key, Object element)
        {
            Elements.Remove(key);
            Elements.Add(key, element);
        }
    }
}
