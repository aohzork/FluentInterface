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
            ITopping espresso = new FluentCoffee();

            //Act
            espresso.AddBeans(BeanType.Arabica).GrindBeans(true).AddWater(30).Serve();

            //Assert
            Assert.IsNotNull(espresso);

        }
    }
}
