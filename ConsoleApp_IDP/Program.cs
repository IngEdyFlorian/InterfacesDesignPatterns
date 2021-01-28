using System;
using IDP_Lib.Interface;
using IDP_Lib;

namespace ConsoleApp_IDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirPlane airPlane = DefaultFactory.CreateTransport<IAirPlane>();
            IShip ship = DefaultFactory.CreateTransport<IShip>();

            Console.WriteLine(airPlane.Deliver());
            Console.WriteLine(airPlane.Fly());
            Console.WriteLine(ship.cruise());        }
    }
}
