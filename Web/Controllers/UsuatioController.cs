using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class UsuatioController : Controller
    {
        // GET: Usuatio
        public ActionResult Index()
        {
            using (var db= new inventario2021Entities())
            {
                return View(db.usuario.ToList());
            }
            
        }
    }
}