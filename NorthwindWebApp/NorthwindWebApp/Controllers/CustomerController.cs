using NorthwindWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWebApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            //1.luodaan luokan ilmentymä
            northwindEntities entities = new northwindEntities();

            //2.haetaan lista Customers-taulun olioista = tietokantakysely
            List<Customers> model = entities.Customers.ToList();

            //3.suljetaan tietokantayhteys
            entities.Dispose();

            //4.kerrotaan mitä näytetään
            return View(model);
        }
    }
}