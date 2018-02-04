using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {

        [TestMethod()]
        public void prisTest()
        {
            //arrange 
            var mc = new MC("1234567", DateTime.Now, false, 125);

            //act
            int mcPris = mc.PrisForBilletStorebæltOgLille();

            //Assert
            Assert.AreEqual(125, mcPris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            //arrange 
            var mc = new MC("1234567", DateTime.Now, false, 125);

            //act
            string køretøj = mc.køreTøj();

            //Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod()]
        public void MCCheckMedBrobizz()
        {
            //arrange 
            var MC = new MC("1234567", DateTime.Now, true, 125);

            //act
            int pris = MC.PrisMedBrobizz();

            //Assert
            Assert.AreEqual(119, pris);
        }

        [TestMethod()]
        public void MCPrisOverstorebæltUdenBrobizz()
        {
            //arrange 
            var MC = new MC("1234567", DateTime.Now, false, 125);

            //act
            int pris = MC.prisOverØresundsbro();
            //bil.Dato.DayOfWeek = DayOfWeek.Friday;

            //Assert
            Assert.AreEqual(210, pris);
        }
        public void MCPrisOverstorebæltMedBrobizz()
        {
            //arrange 
            var MC = new MC("1234567", DateTime.Now, true, 125);

            //act
            int pris = MC.prisOverØresundsbro();
            //bil.Dato.DayOfWeek = DayOfWeek.Friday;

            //Assert
            Assert.AreEqual(73, pris);
        }
    }
}