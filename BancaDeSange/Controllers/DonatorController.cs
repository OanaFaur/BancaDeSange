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
    public class DonatorController : Controller
    {
        // GET: Donator
        [HttpGet]
        public ActionResult Doneaza(int i =0)
        {
            Donatori2 donator = new Donatori2();
            return View();
        }
        [HttpPost]
        public ActionResult Doneaza(BancaDeSange.Models.Donatori2 donator) {

            using (BancaModel dn = new BancaModel())
            {

                var adunare = dn.Bancas.FirstOrDefault(x => x.Grupa_de_sange == donator.Grupa_de_sange  && x.Rh_ul == donator.Rh_ul);

                {

                    if (adunare != null)
                    {
                        adunare.Cantitatea = adunare.Cantitatea + donator.Cantitatea;
                        dn.Donatori2.Add(donator);
                        dn.SaveChanges();
                        

                        return View("Donatie");
                    }

                    return View("Doneaza");

                }
            }
            
            
            
        }

        
        
    }
}