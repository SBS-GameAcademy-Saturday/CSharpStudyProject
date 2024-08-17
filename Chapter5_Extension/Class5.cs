using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_Extension
{
    /// <summary>
    /// Event (이벤트)
    /// 목표: 이벤트를 사용하여 특정 상황이 발생했을 때 알림을 받는 방법을 이해한다.
    /// 
    /// 이벤트(Event)는 C#에서 객체나 클래스가 특정 상황이 발생했음을 다른 객체에 알리는 메커니즘을 제공합니다. 
    /// 이벤트를 사용하면 이벤트를 발생시키는 객체(발행자, Publisher)와 이벤트에 반응하여 
    /// 특정 작업을 수행하는 객체(구독자, Subscriber) 사이의 소통이 가능해집니다. 
    /// 이벤트는 대리자(Delegate)를 기반으로 하며, 이벤트 처리를 위한 메서드(이벤트 핸들러)를 이벤트에 연결하고, 
    /// 특정 조건이 만족될 때 이벤트를 발생시켜 연결된 메서드가 호출되도록 합니다.
    /// 
    /// 이벤트의 주요 특징:
    /// 1, 캡슐화: 이벤트는 대리자를 기반으로 하지만, 이벤트는 외부에서 직접 호출할 수 없으며, 
    /// 오직 이벤트를 정의한 클래스 내에서만 발생시킬 수 있습니다. 
    /// 이를 통해 이벤트의 사용을 캡슐화하고, 클래스 외부에서 이벤트의 발생을 제어하는 것을 방지합니다.
    /// /// 
    /// 2, 구독 및 해지: 이벤트에 대한 구독은 += 연산자를 사용하여 이벤트 핸들러를 추가함으로써 이루어지며, 
    /// -= 연산자를 사용하여 구독을 해지할 수 있습니다.
    /// 
    /// 3, 알림 메커니즘: 이벤트는 클래스나 객체가 특정 상황을 외부에 알릴 필요가 있을 때 사용됩니다. 
    /// 예를 들어, 사용자의 클릭, 데이터의 변경, 타이머의 만료 등 다양한 상황에서 이벤트를 사용할 수 있습니다.
    /// </summary>
    public class Class5
    {
        public class MyEventArgs : EventArgs
        {
            public MyEventArgs(string message) { Message = message; }
            public string Message { get; set; }
        }

        public class Publisher
        {
            public event EventHandler<MyEventArgs> RaiseCustomEvent;

            protected virtual void OnRaiseCustomEvent(MyEventArgs e)
            {
                EventHandler<MyEventArgs> handler = RaiseCustomEvent;
                handler?.Invoke(this, e);
            }

            public void DoSomething()
            {
                OnRaiseCustomEvent(new MyEventArgs("Event triggered"));
            }
        }

        public class Subscriber
        {
            private string id;
            public Subscriber(string ID, Publisher pub)
            {
                id = ID;
                pub.RaiseCustomEvent += HandleCustomEvent;
            }

            void HandleCustomEvent(object sender, MyEventArgs e)
            {
                Console.WriteLine($"{id} received this message: {e.Message}");
            }
        }

        public void Run()
        {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("Subscriber 1", pub);
            Subscriber sub2 = new Subscriber("Subscriber 2", pub);

            // 이벤트 발생
            pub.DoSomething();
        }
    }
}