using System;

namespace Design_Patterns.Behavioral.Observer
{
    public class ClientA : IObserver
    {
        public void ReceiveUpdate()
        {
            Console.WriteLine("Client A Goes to the market!");
        }
    }
    
    public class ClientB : IObserver
    {
        public void ReceiveUpdate()
        {
            Console.WriteLine("Client B Calls to reserve the Product");
        }
    }
}