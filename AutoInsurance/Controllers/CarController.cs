using AutoInsurance.Business;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class CarController : Controller
    {
        public ActionResult SelectCar(ProposalViewModel obj)
        {
            CarBusiness carBusiness = new CarBusiness();

            obj.Cars = carBusiness.FindAll();
            return View(obj);
        }

    }
}
