using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Empleado
    {
        [Key]
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Tanda_Labor { get; set; }
        public string Porciento_Comision { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Estado { get; set; }
    }
}
