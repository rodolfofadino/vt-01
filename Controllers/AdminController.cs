using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vitat_web.Contexts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vitat_web.Controllers
{
    public class AdminController : Controller
    {
        private ReceitasContext _context;

        public AdminController(ReceitasContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var receitas = _context.Receitas.Where(a=>a.Titulo.Contains("batata")).ToList();


            return View(receitas);
        }
    }
}

