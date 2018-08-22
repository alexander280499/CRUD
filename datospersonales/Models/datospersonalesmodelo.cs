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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }

    public class datospersonalescontext : DbContext
    {
        public DbSet<datospersonalesmodelo> DatosPersonales { get; set; }



    }
}