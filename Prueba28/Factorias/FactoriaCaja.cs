using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba28.Modelo;

namespace Prueba28.Factorias
{
    public class FactoriaCaja : IFactoriaObjetos
    {
        public override Object NewObject(List<String> values)
        {
            String id = values.ElementAt(0);
            
            Caja caja = new Caja() { Id = id, Tickets = new List<Ticket>() };

            Contexto Context = Contexto.GetUnicaInstancia(Program.tipo);
            Context.Add(id, caja);

            IRepository repo;
            Context.Entities.TryGetValue(typeof(Ticket), out repo);

            for (int i=1; i<values.Count; i++)
            {
                Ticket ticket = (Ticket) repo.RecuperateParticular(values.ElementAt(i));
                caja.Tickets.Add(ticket);
            }

            new Seguridad(caja);

            return caja;
        }
    }
}
