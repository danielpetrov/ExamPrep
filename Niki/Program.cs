namespace Computers.UI
{
    using System;
    using Logic.ComputerTypes;
    using Logic.Manifacturer;

    public class Program
    {
        private const string ExitCommand = "Exit";
        private const string ChargeCommand = "Charge";
        private const string PlayCommand = "Play";
        private const string ProcessCommand = "Process";
        private const string InvalidCommandMessage = "Invalid command!";

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
            //// TODO introduce command design pattern
            while (true)
            {
                var c = Console.ReadLine();

                if (c == null)
                {
                    break;
                }

                if (c.StartsWith(ExitCommand))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    throw new ArgumentException(InvalidCommandMessage);
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == ChargeCommand)
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == ProcessCommand)
                {
                    server.Process(ca);
                }
                else if (cn == PlayCommand)
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine(InvalidCommandMessage);
                }
            }
        }
     }
}
