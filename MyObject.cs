using System;

namespace MODULE3HW3
{
    public class MyObject
    {
        public event EventHandler<EventArgs> EventHandler;

        public void Notify(EventArgs eventArgs)
        {
            EventHandler?.Invoke(this, eventArgs);
        }
    }   
}