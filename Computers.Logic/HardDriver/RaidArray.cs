namespace Computers.Logic.HardDriver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidArray : HardDriver
    {
        private const string NoHardDriveErrorMessage = "No hard drive in the RAID array!";

        private List<HardDriver> hardDrives;

        public RaidArray(List<HardDriver> hardDrives)
        {
            this.hardDrives = hardDrives;
        }

        public override int Capacity
        {
            get
            {
                if (!this.hardDrives.Any())
                {
                    return 0;
                }

                return this.hardDrives.First().Capacity;
            }
        }

        public override void SaveData(int addr, string newData)
        {
            foreach (var hardDrive in this.hardDrives)
            {
                hardDrive.SaveData(addr, newData);
            }
        }

        public override string LoadData(int address)
        {
            if (!this.hardDrives.Any())
            {
                //TODO what the puck
                throw new OutOfMemoryException(NoHardDriveErrorMessage);
            }

            return this.hardDrives.First().LoadData(address);
        }
    }
}
