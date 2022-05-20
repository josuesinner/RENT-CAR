using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Tipo_Vehiculo
    {
        [Key]
        public int Id_Tipo_Vehiculo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
