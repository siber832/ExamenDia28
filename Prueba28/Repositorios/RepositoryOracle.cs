using System;
using System.Collections.Generic;

namespace Prueba28
{
    public class RepositoryOracle : IRepository
    {
        public override void Commit()
        {
            throw new NotImplementedException();
        }

        public override void Initizalize()
        {
            //TODO Se recuperan todas las entidades y por cada una...
            String key = "";
            Object o = Factoria.NewObject(new List<String>());
            Add(key, o);
        }

        public override object RecuperateParticular(object key)
        {
            //TODO Recupera una entidad concreta con Id Key, y se le pasan los atributos a la factoria
            Object o = Factoria.NewObject(new List<String>());
            Add(key, o);
            return o;
        }
    }
}
