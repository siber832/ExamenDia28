using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba28.Factorias
{
    public class FactoriaTicket : IFactoriaObjetos
    {
        public override Object NewObject(List<String> values)
        {
            String id = values.ElementAt(0);
            double price = Double.Parse(values.ElementAt(1));
            
            Ticket ticket = new Ticket() { Price = price, Id = id };
            return ticket;
        }
    }
}
