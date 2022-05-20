using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Renta_Devolucion
    {
        [Key]
        public int No_Renta { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo Vehículo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha_Renta { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public string Monto_Día { get; set; }
        public int Cantidad_días { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
    }
}
