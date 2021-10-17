namespace MODULE3HW3
{
    public class Starter
    {
        public void Run()
        {
            var myObject = new MyObject();
            var myObserver1 = new Observer(1, myObject);
            var myObserver2 = new Observer(2, myObject);
            var myObserver3 = new Observer(3, myObject);

            myObserver1.Attach();
            myObserver2.Attach();
            myObserver3.Attach();

            myObject.Notify(new EventArgs() { Message = "all notification observer" });

            myObserver1.Detach();
            myObserver3.Detach();

            myObject.Notify(new EventArgs() { Message = $"message after detached" });
        }
    }
}