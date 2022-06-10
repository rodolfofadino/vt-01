using System;
namespace vitat_web.Models
{
	public class Receita
	{
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Categoria { get; set; }
        public string Descricao { get; set; }
        public int  TempoDePreparo { get; set; }
        public string Ingredientes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
      
    }
}

