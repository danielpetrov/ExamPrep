namespace Computers.Logic.Manifacturer
{
    public class ManifacturersFactory
    {
        private const string InvalidManifacturerMessage = "Invalid manufacturer!";

        public IComputerFactory GetManifacturer(string manifacturerName)
        {
            if (manifacturerName == HPComputersFactory.Name)
            {
                return new HPComputersFactory();
            }
            else if (manifacturerName == DellComputersFactory.Name)
            {
                return new DellComputersFactory();
            }
            else if (manifacturerName == LenovoComputersFactory.Name)
            {
                return new LenovoComputersFactory();
            }
            else
            {
                throw new InvalidArgumentException(InvalidManifacturerMessage);
            }
        }
    }
}
