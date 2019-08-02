using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordConverter;
using NumberToWordConverter.Controllers;
using NumberToWordConverter.Models;

namespace NumberToWordConverter.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestNumberAsZero()
        {
            NumberToWordModel model = new NumberToWordModel();
            model.Number = 0;

            HomeController controller = new HomeController();
            ViewResult result = controller.Index(model) as ViewResult;
            model = result.Model as NumberToWordModel;
            Assert.IsTrue(model.OutPut == "Zero");
        }


        [TestMethod]
        public void TestNumberAsTwentyOne()
        {
            NumberToWordModel model = new NumberToWordModel();
            model.Number = 21;

            HomeController controller = new HomeController();
            ViewResult result = controller.Index(model) as ViewResult;
            model = result.Model as NumberToWordModel;
            Assert.IsTrue(model.OutPut == "Twenty One");
        }

        [TestMethod]
        public void TestNumberAs105()
        {
            NumberToWordModel model = new NumberToWordModel();
            model.Number = 105;

            HomeController controller = new HomeController();
            ViewResult result = controller.Index(model) as ViewResult;
            model = result.Model as NumberToWordModel;
            Assert.IsTrue(model.OutPut.Contains("One Hundred and Five"));
        }

        [TestMethod]
        public void TestNumberWithMillion()
        {
            NumberToWordModel model = new NumberToWordModel();
            model.Number = 999999999;

            HomeController controller = new HomeController();
            ViewResult result = controller.Index(model) as ViewResult;
            model = result.Model as NumberToWordModel;
            Assert.IsTrue(model.OutPut.Contains("Nine Hundred and Ninety Nine Million Nine Hundred and Ninety Nine Thousand Nine Hundred and Ninety Nine"));
        }


        [TestMethod]
        public void TestNumberWithWrongValue()
        {
            NumberToWordModel model = new NumberToWordModel();
            model.Number = 2;

            HomeController controller = new HomeController();
            ViewResult result = controller.Index(model) as ViewResult;
            model = result.Model as NumberToWordModel;
            Assert.IsFalse(model.OutPut.Contains("Nine"));
        }
    }
}
