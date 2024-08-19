using System;
using System.Text;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
namespace ProgramClass
{
    class Program
    {
        // 간단한 이벤트 예제: 버튼 클릭
        public class Button
        {
            // 이벤트 선언: 버튼이 클릭되었음을 알리는 이벤트
            public event EventHandler ButtonClicked;

            // 버튼 클릭 메서드
            public void Click()
            {
                Console.WriteLine("Button was clicked!");

                // 이벤트 발생
                OnButtonClicked(EventArgs.Empty);
            }

            // 이벤트 발생 메서드
            protected virtual void OnButtonClicked(EventArgs e)
            {
                // 이벤트가 구독된 경우에만 실행
                if (ButtonClicked != null)
                {
                    ButtonClicked(this, e);
                }
            }
        }

        // 구독자(Subscriber) 클래스
        public class Subscriber
        {
            private string name;

            // 생성자에서 버튼의 클릭 이벤트를 구독
            public Subscriber(string name, Button button)
            {
                this.name = name;
                button.ButtonClicked += HandleButtonClick;
            }

            // 이벤트 핸들러 메서드: 버튼이 클릭되었을 때 실행
            void HandleButtonClick(object sender, EventArgs e)
            {
                Console.WriteLine($"{name} received the ButtonClicked event.");
            }
        }


        public static void Run()
        {
            // 버튼 인스턴스 생성
            Button button = new Button();

            // 두 구독자(Subscriber) 생성 및 버튼 클릭 이벤트 구독
            Subscriber sub1 = new Subscriber("Subscriber 1", button);
            Subscriber sub2 = new Subscriber("Subscriber 2", button);

            // 버튼 클릭
            button.Click();
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
