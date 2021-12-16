using System;
using Microsoft.AspNetCore.Mvc;

namespace GestionUsuarios.Controllers
{
    public class AppController : Controller
    {
        //GET : Usuarios
        public IActionResult Index()
        {
            return View();
        }

    }

}