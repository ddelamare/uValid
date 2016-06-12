using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UV.Collections;
using UV.Factories;
using UV.Units;
using UVWebFrontTest.Models;

namespace UVWebFrontTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var validator = new UVExpression();

            validator. BeginGrouping().
                            IsNotNull("prop1").
                            And().
                            IsNotNull("prop2", "prop3").
                        EndGrouping().
                        Or().
                        IsNotNull("prop4");

            var fac = new EnglishFactory();
            ViewBag.Expression = validator.Generate(fac);

            object modelToValidate = new TestModel();
            validator.Validate(modelToValidate);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}