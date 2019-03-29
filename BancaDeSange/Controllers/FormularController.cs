using BancaDeSange.Filters;
using BancaDeSange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaDeSange.Controllers
{
    [UserAuthentificationFilter]
    [FilterConfig.NoDirectAccess]

    public class FormularController : Controller
    {
        // GET: Formular
        [HttpGet]
        public ActionResult Completeaza()
        {
            return View();
        }

        [HttpPost]

        [Authorize(Roles ="Cere")]
        public ActionResult Completeaza(BancaDeSange.Models.Formular fb) {

            using(BancaModel bm = new BancaModel()) {

                var grupaSange = bm.Bancas.FirstOrDefault(x => x.Grupa_de_sange == fb.Grupa && x.Cantitatea >= fb.Cantitatea && x.Rh_ul == fb.Rh_ul);
                {
                    // FormularBaza fm = new FormularBaza();
                    Session["UserID"] = Guid.NewGuid();

                    if (grupaSange != null) {

                        //Banca b = new Banca();
                        //b.Cantitatea = b.Cantitatea - fb.Cantitatea;
                        grupaSange.Cantitatea = grupaSange.Cantitatea - fb.Cantitatea;

                        bm.Formulars.Add(fb);
                        //  fm.Formulars.Add(fb);

                        //fm.SaveChanges();

                        //  fm.Formulars.ToList();
                        bm.SaveChanges();
                     //   ViewBag.SuccesMessage = "Cererea dumneavoastra a fost inregistrata";
                        return View("ListaAsteptare", bm.Formulars.ToList());
                    }
                    else {

                        return View("~/Views/Formular/Eroare.cshtml");

                    }
                    
                }
                
            }



        }

        public ActionResult ListaAsteptare() {


            var lista = new FormularBaza();


            return View(lista.Formulars.ToList());

        }
    }
}