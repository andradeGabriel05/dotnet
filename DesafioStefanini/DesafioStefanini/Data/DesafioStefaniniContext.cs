using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioStefanini.Models;

namespace DesafioStefanini.Data
{
    public class DesafioStefaniniContext : DbContext
    {
        public DesafioStefaniniContext (DbContextOptions<DesafioStefaniniContext> options)
            : base(options)
        {
        }

        public DbSet<DesafioStefanini.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<DesafioStefanini.Models.Produto> Produto { get; set; } = default!;
        public DbSet<DesafioStefanini.Models.ItensPedido> ItensPedido { get; set; } = default!;

        
    }
}
