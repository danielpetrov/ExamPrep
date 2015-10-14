namespace Computers.Logic.HardDriver
{
    using System.Collections.Generic;

    public class SingleHardDriver : HardDriver
    {
        private int capacity;
        private Dictionary<int, string> data;

        public SingleHardDriver(int capacity)
        {
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }

        public override int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public override void SaveData(int addr, string newData)
        {
            this.data[addr] = newData;
        }

        public override string LoadData(int address)
        {
            return this.data[address];
        }
    }
}
