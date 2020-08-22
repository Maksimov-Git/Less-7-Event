using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_7_Event
{
    public delegate void EventDelegate();

    public class MyClass
    {
    // ключевое слово EVENT, указывает на то, что поле(уже не поле) класса  является событием
     public event EventDelegate myEvent = null;

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
            
            myClass.myEvent += new EventDelegate(Handler1);
            // создаем экземпляр класса EventDelegate и сообщаем с ним обработчик  Handler1 и подписываем 
            // обработчик на событие  myEvent
           
            // предположение делегата
            myClass.myEvent += Handler2;

            myClass.InvokeEvent();

            Console.WriteLine(" ");

            myClass.myEvent -= Handler1;
            myClass.InvokeEvent();

            Console.ReadKey();
        }
    }
}
