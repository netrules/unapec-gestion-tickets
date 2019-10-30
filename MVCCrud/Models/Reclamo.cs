using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Reclamo
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Razon del reclamo")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Un comentario de hasta 500 letras")]
        public string Description { get; set; }
    }

    public class CompanyDBContext: DbContext
    {
        public DbSet<Reclamo> Reclamos { get; set; }
    }
}