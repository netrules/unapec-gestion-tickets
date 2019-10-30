using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Materia
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de la materia")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Carrera a la que pertenece")]
        public string Carrera { get; set; }
    }

    public class MateriaDBContext: DbContext
    {
        public DbSet<Materia> Materias { get; set; }
    }
}