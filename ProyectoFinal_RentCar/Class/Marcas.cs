using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Marcas
    {
        [Key]
        public int Id_Marca { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
    
}
