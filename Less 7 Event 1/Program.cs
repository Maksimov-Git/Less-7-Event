using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_7_Event_1
{
    public delegate void EventDelegate(string S);

    public class MyClass
    {
        EventDelegate myEvent = null;
   
        public event EventDelegate MyEvent
        {
            add
            {
                if (value != null)
                {
                    myEvent += value;
                }
            }
            remove
            {
            myEvent -= value; 
            }
        }

        public void InvokeEvent(String S)
        {
            myEvent.Invoke(S);
        }

    }
    class Program
    {
        static private void Handler1( string S) // handler - обработчик
        {
            Console.WriteLine("произошло событие 1" + S);
        }
        // методы обработчики событий
        static private void Handler2(string S)
        {
            Console.WriteLine("произошло событие 2"+S);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите имя ");
            String S = Console.ReadLine(); 
            MyClass myClass = new MyClass();

            myClass.MyEvent += new EventDelegate(Handler1);
            
            myClass.MyEvent += Handler2;

            myClass.InvokeEvent(S);

            Console.Read();

        }
    }
}
