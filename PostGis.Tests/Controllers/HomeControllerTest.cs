using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using PostGis;
using PostGis.Controllers;
using PostGis.DAL.Providers;
using System.Configuration;
using PostGis.Model;

namespace PostGis.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateDatabase()
        {
            PgSqlDataServicesProvider pgSqlDataServices=new PgSqlDataServicesProvider(ConfigurationManager.ConnectionStrings[0].ToString());
            ISessionFactory factory = pgSqlDataServices.CreateSessionFactory();
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Acls acls=new Acls();
                    acls.Address = "abc";
                    
                    

                    session.SaveOrUpdate();
                    transaction.Commit();
                }
            }
        }
    }
}
