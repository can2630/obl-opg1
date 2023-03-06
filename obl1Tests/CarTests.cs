using Microsoft.VisualStudio.TestTools.UnitTesting;
using obl1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obl1.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void ValidateIdTest()
        {
            var car = new Car { Id = 1 };
            Assert.IsTrue(car.ValidateId());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            var car = new Car { Model = "toyota corola" };
            Assert.IsTrue(car.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            var car = new Car { Price= 1000 };
            Assert.IsTrue(car.ValidatePrice());
        }

        [TestMethod()]
        public void ValidatelicensePlateTest()
        {
            var car = new Car { LicensPlate = "jef234" };
            Assert.IsTrue(car.ValidatelicensePlate());
            
        }

       
    }
}

