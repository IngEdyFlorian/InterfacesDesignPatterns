using System;
using System.Collections.Generic;
using System.Text;
using IDP_Lib.Interface;

namespace IDP_Lib
{
    public class Ship : IShip
    {
        public string cruise()
        {
            return "cross the sea";
        }
    }
}
