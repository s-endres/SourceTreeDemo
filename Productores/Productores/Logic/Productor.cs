using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productores.Logic
{
    public class Productor
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int fincas { get; set; }

        public Productor()
        {

        }

        public Productor(int pid, string pnombre, string ptelefono, string pemail, int pfincas)
        {
            this.id = pid;
            this.nombre = pnombre;
            this.telefono = ptelefono;
            this.email = pemail;
            this.fincas = pfincas;
        }

    }
}