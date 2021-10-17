using System;
using System.Dynamic;

namespace MODULE3HW3
{
    public class Observer
    {
        public int Id { get; }

        public MyObject MyObject { get;}

        public Observer(int id, MyObject myObject)
        {
            Id = id;
            MyObject = myObject;
        }

        public void Attach()
        {
            MyObject.EventHandler += Action;
        }

        public void Detach()
        {
            MyObject.EventHandler -= Action;
        }

        public void Action(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($"{Id} message: {eventArgs.Message}");
        }
    }
}