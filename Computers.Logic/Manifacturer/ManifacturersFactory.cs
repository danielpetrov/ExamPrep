using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Logic.Manifacturer
{
    public class ManifacturersFactory
    {
        public IComputerFactory GetManifacturer(string manifacturerName)
        {
            if (manifacturerName == "HP")
            {
                return new HPComputersFactory();
            }
            else if (manifacturerName == "Dell")
            {
                return new DellComputersFactory();
            }
            else if (manifacturerName == "Lenovo")
            {
                return new LenovoComputersFactory();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }
        }
    }
}
