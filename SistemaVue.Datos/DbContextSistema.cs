using Microsoft.EntityFrameworkCore;
using SistemaVue.Datos.Mapping.Almacen;
using SistemaVue.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVue.Datos
{
    public class DbContextSistema: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
