using System;
using System.Collections.Generic;

namespace Prueba28.Modelo
{
    class Caja
    {
        public String Id { get; set; }
        public event EventHandler Achieved;
        public List<Ticket> Tickets { get; set; }
        protected void MaximumAchieved(EventArgs e)
        {
            EventHandler copyAchieved = Achieved;
            if (copyAchieved != null)
                copyAchieved(this, e);
        }
        public delegate void EventHandler(object sender, EventArgs args);
    }
}
