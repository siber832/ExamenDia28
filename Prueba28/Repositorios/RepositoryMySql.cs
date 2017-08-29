using System;
using System.Collections.Generic;

namespace Prueba28
{
    public class RepositoryMySql : IRepository
    {
        public override void Commit()
        {
            //TODO Guardar los cambios usando la clase Type para descubrir los campos del tipo.
            throw new NotImplementedException();
        }

        public override void Initizalize()
        {
            throw new NotImplementedException();
        }

        public override Object RecuperateParticular(Object key)
        {
            //TODO Recupera una entidad concreta con Id Key, y se le pasan los atributos a la factoria
            Object o = Factoria.NewObject(new List<String>());
            Add(key, o);
            return o;
        }
    }
}
