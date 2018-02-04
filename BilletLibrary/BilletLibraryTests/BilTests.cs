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
            var bil = new Bil("1234567", DateTime.Now, false, 240);

            //act
            int bilPris = bil.PrisForBilletStorebæltOgLille();

            //Assert
            Assert.AreEqual(240, bilPris);
        }

        [TestMethod()]
        public void bilKøretøjTest()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, false, 240);

            //act
            string køretøj = bil.køreTøj();

            //Assert
            Assert.AreEqual("bil", køretøj);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),    
            "nummerpladens længde er store end 8")]
        public void BilNummerpladeForLang()
        {
            //arrange 
            var bil = new Bil("12345678", DateTime.Now, false, 240);
        }

        [TestMethod()]
        public void MetodeCheckBrobizz()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, true, 240);

            //act
            int pris = bil.PrisMedBrobizz();
            //bil.Dato.DayOfWeek = DayOfWeek.Friday;

            //Assert
            Assert.AreEqual(228, pris);
        }

        [TestMethod()]
        public void bilPrisMedBrobizzOgWeekendtilbud()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, true, 240);
            bil.DaysOfWeek = DayOfWeek.Saturday;

            //act
            int pris = bil.PrisForBilletStorebæltOgLille();

            //Assert
            Assert.AreEqual(183, pris);
        }


        [TestMethod()]
        public void bilPrisMedBrobizz()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, true, 240);
            bil.DaysOfWeek = DayOfWeek.Monday;

            //act
            int pris = bil.PrisForBilletStorebæltOgLille();

            //Assert
            Assert.AreEqual(228, pris);
        }

        [TestMethod()]
        public void bilPrisOverstorebæltUdenBrobizz()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, false, 240);

            //act
            int pris = bil.prisOverØresundsbro();
            //bil.Dato.DayOfWeek = DayOfWeek.Friday;

            //Assert
            Assert.AreEqual(410, pris);
        }
        [TestMethod()]
        public void bilPrisOverstorebæltMedBrobizz()
        {
            //arrange 
            var bil = new Bil("1234567", DateTime.Now, true, 240);

            //act
            int pris = bil.prisOverØresundsbro();
            //bil.Dato.DayOfWeek = DayOfWeek.Friday;

            //Assert
            Assert.AreEqual(161, pris);
        }


    }
}