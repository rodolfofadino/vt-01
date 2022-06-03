using System;
using Microsoft.AspNetCore.Mvc;

namespace vitat_web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
        {
			//acesso ao banco de dados
			var hora = DateTime.Now.ToString();

			ViewData["horario"] = hora;

			ViewBag.HoraDoBrasil = hora;


			ViewData["horario"] = hora;
			ViewBag.horario = hora;
			ViewData["horario"] = "cucharro";


			var pessoa = new Pessoa();
			pessoa.Nome = "Rebeca";
			pessoa.Idade = 25;

			var homeViewModel = new HomeViewModel()
			{ Pessoa = pessoa, Hora = hora };
			
			return View(homeViewModel);
		}


		public string ListaDeCategorias(string category)
		{

			return "Lista de " +category;
		}
	}

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }


	public class HomeViewModel
    {
        public Pessoa Pessoa { get; set; }
        public string Hora { get; set; }
    }
}

