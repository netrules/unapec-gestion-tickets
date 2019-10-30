using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Carrera
    {
        public int ID { get; set; }
        [Required]
        [StringLength(6)]
        [Display(Name = "Codigo de la carrera")]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Nombre de la carrera")]
        public string Direccion1 { get; set; }
    }

    public class CarreraDBContext: DbContext
    {
        public DbSet<Carrera> Carrera { get; set; }
    }
}