using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Modelos
    {
        [Key]
        public int Id_Modelo { get; set; }
        public int MarcaId { get; set; }
        public Marcas Marca { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
