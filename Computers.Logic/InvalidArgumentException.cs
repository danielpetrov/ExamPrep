namespace Computers.Logic
{
    using System;
    ////TODO remove or rename
    public class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string message) 
            : base(message)
        {
        }
    }
}
