using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancaDeSange.Models;
using System.Data.Entity;
using BancaDeSange.Filters;

namespace BancaDeSange.Controllers
{
    [UserAuthentificationFilter]
    [FilterConfig.NoDirectAccess]
    public class BancaController : Controller
    {

        private BancaModel bm = new BancaModel();
       
        // GET: Banca
        public ActionResult Resurse()
        {

            var resurse = new BancaModel();

            
            

            return View(resurse.Bancas.ToList());

        }
        
    }
}