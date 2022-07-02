namespace Design_Patterns.Behavioral.Observer
{
    public interface ISubject
    {
        
        void Attach(IObserver observer);
        void Desattach(IObserver observer);
        void Notify();
    }
}