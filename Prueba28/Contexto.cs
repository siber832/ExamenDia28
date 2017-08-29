using System;
using System.Collections.Generic;

namespace Prueba28
{
    public class Contexto
    {

        public Dictionary<Type, IRepository> Entities { get; set; }
        public IFactoria Factoria { private get; set; }
        private static Contexto UnicaInstancia;

        private Contexto() {   }

        public void Add(Object k, Object o)
        {
            Type t = o.GetType();
            IRepository repo;
            Entities.TryGetValue(t, out repo);
            repo.Add(k, o);
        }

        public void SaveChanges()
        {
            foreach(IRepository repo in Entities.Values)
            {
                repo.Commit();
            }
        }

        public void Inicializar(params Type[] lista)
        {
            Entities = new Dictionary<Type, IRepository>();
            foreach (Type t in lista)
            {
                IRepository repo = Factoria.CreateRepository(t);
                repo.Initizalize();
                Entities.Add(t, repo);
            }
        }

        public void Remove(Object o)
        {
            Type t = o.GetType();
            IRepository repo;
            Entities.TryGetValue(t, out repo);
            repo.Remove(o);
        }

        public void Update(Object k, Object o)
        {
            Type t = o.GetType();
            IRepository repo;
            Entities.TryGetValue(t, out repo);
            repo.Update(k, o);
        }

        public static Contexto GetUnicaInstancia(String tipo)
        {
            if(!UnicaInstancia.Equals(null))
            {
                return UnicaInstancia;
            }
            else
            {
                UnicaInstancia = new Contexto() { Factoria = IFactoria.GetFactoria(tipo) };
                return UnicaInstancia;
            }
        }
    }
}
