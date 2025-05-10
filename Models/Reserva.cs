using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Proyecto2_Forms_Ext.Models
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public int ID_Miembro { get; set; }
        public int ID_Clase { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
