using System;
using System.Collections.Generic;
using System.Text;
using IDP_Lib;
using IDP_Lib.Interface;
using NSubstitute;
using NUnit.Framework;

namespace NUnitTestingFactory
{
    public class FactoryTesting
    {
        [Test]
        public void TestingAirplane()
        {
            //Crea una clase desde el factory de tipo AirPlane
            IAirPlane airPlane = DefaultFactory.CreateTransport<IAirPlane>();

            var sub = Substitute.For<IAirPlane>();
            sub.Deliver().Returns("Deliver Shipping");

            //Valida si el objeto sub implementa la interfaz IAirPlane
            Assert.IsInstanceOf<IAirPlane>(airPlane);

            //valida que el resultado
            Assert.That(sub.Deliver(), Is.EqualTo("Deliver Shipping"));
        }

        [Test]
        public void TestingShip()
        {
            //Crea una clase desde el factory de tipo Ship
            IShip ship = DefaultFactory.CreateTransport<IShip>();

            var sub = Substitute.For<IShip>();
            sub.cruise().Returns("cross the sea");

            //Valida si el objeto sub implementa la interfaz IShip
            Assert.IsInstanceOf<IShip>(ship);

            //valida que el resultado
            Assert.That(sub.cruise(), Is.EqualTo("cross the sea"));
        }      
    }
}