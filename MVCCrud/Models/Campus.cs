using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Campus
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del campus")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(250)]
        [Display(Name = "Un comentario de hasta 500 letras")]
        public string Direccion1 { get; set; }
    }

    public class CampusDBContext: DbContext
    {
        public DbSet<Campus> Campuses { get; set; }
    }
}