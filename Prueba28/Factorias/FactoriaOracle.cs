using System;
using Prueba28.Factorias;

namespace Prueba28
{
    class FactoriaOracle : IFactoria
    {
        public override IRepository CreateRepository(Type t)
        {
            return new RepositoryOracle() { Factoria = IFactoriaObjetos.GetFactoria(t) };
        }
    }
}
