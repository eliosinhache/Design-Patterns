using Design_Patterns.Behavioral.Observer;

namespace Design_Patterns.PatternsRunners
{
    public class ObserverRun
    {
        public ObserverRun()
        {
            Market market = new Market();
            ClientA clientA = new ClientA();
            ClientB clientB = new ClientB();
            
            market.Attach(clientA);
            market.Attach(clientB);
            
            market.EnterSuperRequiredProduct(2);
            
            
        }
    }
}