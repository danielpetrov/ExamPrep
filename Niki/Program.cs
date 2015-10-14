namespace Computers.UI
{
    using System;
    using Logic;
    using Logic.ComputerTypes;
    using Logic.Manifacturer;

    public class Program
    {
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();
            ProccesCommands();
        }

        private static void CreateComputers()
        {
            var manufacturerName = Console.ReadLine();

            var manifacturersFactory = new ManifacturersFactory();

            IComputerFactory computerfactory = manifacturersFactory.GetManifacturer(manufacturerName);

            pc = computerfactory.CreatePersonalComputer();
            laptop = computerfactory.CreateLaptop();
            server = computerfactory.CreateServer();
        }

        private static void ProccesCommands()
        {
            while (true)
            {
                var c = Console.ReadLine();

                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
     }
}
