using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace datospersonales.Models
{
    public class datospersonalesmodelo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Email { get; set; }


        [DataType(DataType.Url)]
        [Required(ErrorMessage ="Este campo es requerido")]
        public string URL { get; set; }
    }

    public class datospersonalescontext : DbContext
    {
        public DbSet<datospersonalesmodelo> DatosPersonales { get; set; }



    }
}