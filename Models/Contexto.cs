using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }   // inicializa a entidade para guardar os dados
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Automovel> Automovels { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }


        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
