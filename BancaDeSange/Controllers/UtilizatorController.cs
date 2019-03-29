using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancaDeSange.Models;
using BancaDeSange.Filters;
using System.Web.Routing;

namespace BancaDeSange.Controllers
{

    [FilterConfig.NoDirectAccess]
    public class UtilizatorController : Controller
    {
        
        [HttpGet]
        // GET: Utilizator
        public ActionResult Adauga(int i =0)
        {
            Utilizatori util = new Utilizatori();
            return View(util);
        }

        [HttpPost]

        public ActionResult Adauga(Utilizatori util) {

            using(SubmitModel sb = new SubmitModel()) {

                sb.Utilizatoris.Add(util);

               // var x = sb.Utilizatoris.Where(x => x.Id == 1);
              //  if(x.Count()>1)
               // foreach (var x1 in x)
                {
                    //x1.Parola = 65;
                }
                sb.SaveChanges();

            }

            ModelState.Clear();
            ViewBag.SuccesMessage = "V-ati inregistrat cu succes";
            return View("Adauga", new Utilizatori());
        }
        
        public ActionResult Login(BancaDeSange.Models.Utilizatori util)
        {



            using (SubmitModel sb = new SubmitModel())
            {



                var detaliiUtilizator = sb.Utilizatoris.Where(x => x.NumeUtilizator == util.NumeUtilizator && x.Parola == util.Parola && x.TipDeUtilizator == util.TipDeUtilizator).Count();
                if (detaliiUtilizator == 1)
                {

                    if (util.TipDeUtilizator == "Cere")
                    {
                        Session["UserID"] = Guid.NewGuid();

                        return View("Logare1");

                    }
                    else if (util.TipDeUtilizator == "Doneaza")
                    {
                        Session["UserID"] = Guid.NewGuid();
                        return View("Login2");



                    }

                    //else { return }

                }

                else { ModelState.AddModelError("", "Revizuiti numele de utilizator, parola, sau tipul de utilizator ales"); }

                return View();
            }
        }
        
    }
}