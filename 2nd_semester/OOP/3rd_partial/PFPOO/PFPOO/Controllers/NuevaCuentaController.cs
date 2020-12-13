using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PFPOO.Controllers
{
    public class NuevaCuentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        protected void btnConfir_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
        }

    }
}