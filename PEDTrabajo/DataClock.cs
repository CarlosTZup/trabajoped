using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDTrabajo
{
    public class DataClock
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Hora { get; set; }
        public string Dias { get; set; }

        public DataClock(int id, string nombre, string hora, string dia)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Hora = hora;
            this.Dias = dia;

        }

    }
}
