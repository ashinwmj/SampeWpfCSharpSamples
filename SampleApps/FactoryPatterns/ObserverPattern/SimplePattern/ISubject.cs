namespace DesignPatterns.ObserverPattern.SimplePattern
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void UnSubsribe(IObserver observer);
        void Notify();
    }
}
