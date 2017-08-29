using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba28.Modelo;

namespace Prueba28.Factorias
{
    public abstract class IFactoriaObjetos
    {
        protected Object obj;
        public static IFactoriaObjetos GetFactoria(Type tipo)
        {
            if (tipo.Equals(typeof(Caja)))
            {
                return new FactoriaCaja();
            }
            return new FactoriaTicket();
        }

        public abstract Object NewObject(List<String> values);
    }
}
