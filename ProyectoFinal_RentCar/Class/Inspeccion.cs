using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Inspeccion
    {
        [Key]
        public int Id_Transacción { get; set; }
        public int VehículoId { get; set; }
        public Vehiculo Vehículo { get; set; }
        public string Cedula { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Tiene_Ralladuras { get; set; }
        public string Cantidad_Combustible  { get; set; }
        public string Goma_respuesta  { get; set; }
        public string Tiene_Gato { get; set; }
        public string roturas_cristal { get; set; }
        public string Estado_gomas  { get; set; }
        public string Etc { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public string Estado { get; set; }

    }
}
