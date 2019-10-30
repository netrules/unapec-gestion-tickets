using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Profesor
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del profesor")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("P([0-9]+)")]      // for 0-inf or 
        [Display(Name = "Matricula del profesor")]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de la Carrera")]
        public string Carrera { get; set; }

    }

    public class ProfesorDBContext: DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
    }
}