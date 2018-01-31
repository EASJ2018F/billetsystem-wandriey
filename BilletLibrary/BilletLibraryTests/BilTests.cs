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
        public void bilPrisTest()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, false);

            //act
            int bilPris = bil.Pris();

            //Assert
            Assert.AreEqual(240, bilPris);
        }

        [TestMethod()]
        public void bilKøretøjTest()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, false);

            //act
            string køretøj = bil.køreTøj();

            //Assert
            Assert.AreEqual("bil", køretøj);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),     //mangler en forklaring. 
            "nummerpladens længde er store end 8")]
        public void BilNummerpladeForLang()
        {
            //arrange 
            var bil = new Bil("12345678", DateTime.Now, false);
        }

        [TestMethod()]
        public void bilCheckMedBrobizz()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, true);

            //act
            int pris1 = bil.PrisMedBrobizz();

            //Assert
            Assert.AreEqual(228, pris1);
        }
    }
}