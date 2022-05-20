using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_RentCar.Class
{
   public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string No_Tarjeta_CR { get; set; }
        public string Límite_Credito { get; set; }
        public string Tipo_Persona  { get; set; }
        public string Estado { get; set; }

    }
}
