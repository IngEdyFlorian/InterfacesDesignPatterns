using System;
using System.Collections.Generic;
using System.Text;
using IDP_Lib.Interface;

namespace IDP_Lib
{
    public class AirPlane : IAirPlane
    {
        public string Deliver()
        {
            return "Deliver Shipping";
        }

        public string Fly()
        {
            return "Fly in the sky";
        }
    }
}
