using System;
using Microsoft.EntityFrameworkCore;
using vitat_web.Models;

namespace vitat_web.Contexts
{
	public class ReceitasContext : DbContext
	{
        public ReceitasContext(DbContextOptions<ReceitasContext> options) : base(options)
        {
			

        }

		public DbSet<Receita> Receitas { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		
	}
}

