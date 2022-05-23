using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ProyectoFinal_RentCar.Class
{
    public class InspeccionViewModel
    {
        [Key]
        public int Id_Transacción { get; set; }
        public string Vehículo { get; set; }
        public string Cedula { get; set; }
        public string Cliente { get; set; }
        public string Tiene_Ralladuras { get; set; }
        public string Cantidad_Combustible { get; set; }
        public string Goma_respuesta { get; set; }
        public string Tiene_Gato { get; set; }
        public string roturas_cristal { get; set; }
        public string Estado_gomas { get; set; }
        public string Etc { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; }
        public string Estado { get; set; }
    }
}
