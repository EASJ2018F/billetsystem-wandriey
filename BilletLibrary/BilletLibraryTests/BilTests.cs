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
    public class BilTests
    {
        [TestMethod()]
        public void prisTest()
        {
            //arrange 
            var bil = new Bil();

            //act
            int bilPris = bil.pris();

            //Assert
            Assert.AreEqual(240, bilPris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            //arrange 
            var bil = new Bil();

            //act
            string køretøj = bil.køreTøj();

            //Assert
            Assert.AreEqual("bil", køretøj);
        }
    }
}