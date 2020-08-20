using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers
{
    public class FilmesController : Controller
    {
        //Endpoint GET que retorna uma VIEW
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        //Endpoint GET que recebe os dados do form
        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if(ModelState.IsValid)
            {
                
            }

            //Retorna uma VIEW, com os dados de filme;
            return View(filme);
        }
    }
}
