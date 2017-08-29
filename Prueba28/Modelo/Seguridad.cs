using System;

namespace Prueba28.Modelo
{
    class Seguridad
    {
        private Caja caja;

        public Seguridad(Caja caja)
        {
            this.caja = caja;
            this.caja.Achieved += new Caja.EventHandler(Clear);
        }

        private void Clear(object sender, EventArgs e)
        {
            Console.WriteLine("He sido llamado.");
            caja.Tickets.Clear();
        }
        public void Detach()
        {
            caja.Achieved -= new Caja.EventHandler(Clear);
            caja = null;
        }
    }
}
