using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RegistroDb : DbContext
    {
        public RegistroDb() : base("name=ConStr") 
        {

        }
        public virtual DbSet<Clientes> Cliente { get; set; }
    }
}
