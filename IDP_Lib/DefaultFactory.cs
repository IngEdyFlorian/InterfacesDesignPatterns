using System;
using System.Collections.Generic;
using System.Text;
using IDP_Lib.Interface;

namespace IDP_Lib
{
    public class DefaultFactory
    {
        public static T CreateTransport<T>()
        {
            if (typeof(T) == typeof(IShip))
            {
                return (T)(IShip)new Ship();
            }
            else
                if (typeof(T) == typeof(IAirPlane))
            {
                return (T)(IAirPlane)new AirPlane();
            }
            else
            {
                throw new NotImplementedException($"Creation of {typeof(T)} interface is not supported yet.");
            }
        }
    }
}
