﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RentCar.Class
{
   public class Combustible
    {
        [Key]
        public int Id_Combustible { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}
