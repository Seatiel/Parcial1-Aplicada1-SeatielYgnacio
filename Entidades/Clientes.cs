using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string FechaNacimiento { get; set; }

        public int LimiteCredito { get; set; }
    }
}
