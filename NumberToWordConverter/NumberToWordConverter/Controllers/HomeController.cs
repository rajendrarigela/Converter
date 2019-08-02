using NumberToWordConverter.Models;
using NumberToWordLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberToWordConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly INumberToWord iNumberToWord;
        public HomeController()
        {
            iNumberToWord = new NumberToWord();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(NumberToWordModel model)
        {
            if (ModelState.IsValid)
                model.OutPut = iNumberToWord.NumToWords(model.Number);

            return View(model);
        }
    }
}