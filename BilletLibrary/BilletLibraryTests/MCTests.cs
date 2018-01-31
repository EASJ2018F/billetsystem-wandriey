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
            var mc = new MC();

            //act
            int mcPris = mc.Pris();

            //Assert
            Assert.AreEqual(125, mcPris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            //arrange 
            var mc = new MC();

            //act
            string køretøj = mc.køreTøj();

            //Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}