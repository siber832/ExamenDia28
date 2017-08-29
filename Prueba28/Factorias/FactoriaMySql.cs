using System;
using Prueba28.Factorias;

namespace Prueba28
{
    class FactoriaMySql : IFactoria
    {
        public override IRepository CreateRepository(Type t)
        {
            return new RepositoryMySql() { Factoria = IFactoriaObjetos.GetFactoria(t) };
        }
    }
}
