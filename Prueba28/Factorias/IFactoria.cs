using System;

namespace Prueba28
{
    public abstract class IFactoria
    {
        public abstract IRepository CreateRepository(Type t);
        public static IFactoria GetFactoria(String tipo)
        {
            if(tipo.Equals("1"))
            {
                return new FactoriaOracle();
            }
            return new FactoriaMySql();
        }
    }
}
