using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Proyecto2_Forms_Ext.Models
{
    public class Membresia
    {
        public int ID_Membresia { get; set; }
        public string TipoMembresia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
