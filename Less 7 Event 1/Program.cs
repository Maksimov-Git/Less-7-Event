using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_7_Event_1
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;
        // ключевое слово EVENT, указывает на то, что поле(уже не поле) класса  является событием
        public event EventDelegate MyEvent
        {
            add 
            {
            myEvent += value;
            }
            remove
            {
            myEvent -= value; 
            }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }

    }
    class Program
    {
        static private void Handler1() // handler - обработчик
        {
            Console.WriteLine("произошло событие 1");
        }
        // методы обработчики событий
        static private void Handler2()
        {
            Console.WriteLine("произошло событие 2");
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MyEvent += new EventDelegate(Handler1);
            
            myClass.MyEvent += Handler2;

            myClass.InvokeEvent();


        }
    }
}
