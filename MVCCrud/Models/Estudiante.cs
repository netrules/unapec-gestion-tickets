using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Estudiante
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del estudiante")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("([0-9]+)")]      // for 0-inf or 
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [Display(Name = "Matricula del estudiante")]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de la Carrera")]
        public string Carrera { get; set; }

    }

    public class EstudianteDBContext: DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}