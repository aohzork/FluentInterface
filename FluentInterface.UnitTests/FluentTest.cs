using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentInterface;


namespace FluentInterface.UnitTests
{
    [TestClass()]
    public class FluentCoffeeTest
    {
        [TestMethod()]
        public void TestEspresso ()
        {
            //Arrange
            IMakeBeverage espresso = new FluentCoffee();
            IMakeBeverage espresso2 = new FluentCoffee();
            //Act
            espresso.AddBeans(Beans.Arabica).GrindBeans(true).AddWater(30);

            //Assert
            Assert.AreEqual(espresso, espresso2.AddWater(30)
                            .AddBeans(Beans.Arabica)
                            .GrindBeans(true));




        }
    }
}
