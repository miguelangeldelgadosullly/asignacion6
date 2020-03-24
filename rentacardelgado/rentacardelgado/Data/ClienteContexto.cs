using Microsoft.EntityFrameworkCore;
using rentacardelgado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rentacardelgado.Data
{
    public class ClienteContexto: DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto> options) : base(options) { 
        
        
        
        
        
        
        
        }

        public DbSet<Cliente> ClienteItems { get; set; }

    }
}
