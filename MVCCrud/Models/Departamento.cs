using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Departamento
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del decanato")]
        public string Name { get; set; }
    }

    public class DepartamentoDBContext: DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
    }
}