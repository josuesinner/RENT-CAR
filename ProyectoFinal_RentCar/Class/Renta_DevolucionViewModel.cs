using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
    public class Renta_DevolucionViewModel
    {
        [Key]
        public int No_Renta { get; set; }
        public string Empleado { get; set; }
        public string Vehículo { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha_Renta { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public string Monto_Día { get; set; }
        public int Cantidad_días { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
    }
}
