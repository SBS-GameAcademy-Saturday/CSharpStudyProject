using System;
using System.Text;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
namespace ProgramClass
{
    class Program
    {
        public class ButtonEventArgs : EventArgs
        {
            public string Message;

            public ButtonEventArgs(string message)
            {
                Message = message;
            }
        }
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
                OnButtonClicked(new ButtonEventArgs("Hello World"));
            }

            // 이벤트 발생 메서드
            protected virtual void OnButtonClicked(ButtonEventArgs e)
            {
                // 이벤트가 구독된 경우에만 실행
                if (ButtonClicked != null)
                {
                    ButtonClicked(this, e);

                    System.Console.WriteLine(e.Message);
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
                button.ButtonClicked -= HandleButtonClick;
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
            int number1 = 5;
            int number2 = 5;
            // 전위 증감 연산자: 먼저 값을 증가시킨 후 사용
            // 후위 증감 연산자: 값을 먼저 사용하고 그 후에 증가시킴
            Console.WriteLine($"증가 연산 [전위 : {++number1}] ,[후위 : {number2++}]");  // 출력: 증가 연산 [전위 : 6] ,[후위 : 5]
            Console.WriteLine($"증가 연산 후 값: {number1} , {number2}");         // 출력: 증가 연산 후 값: 6 , 6

            // 전위 감소 연산자: 먼저 값을 감소시킨 후 사용
            // 후위 감소 연산자: 값을 먼저 사용하고 그 후에 감소시킴
            Console.WriteLine($"감소 연산 [전위 : {--number1}] ,[후위 : {number2--}]");  // 출력: 감소 연산 [전위 : 5] ,[후위 : 6]
            Console.WriteLine($"감소 연산 후 값: {number1} , {number2}");  // 출력: 감소 연산 후 값: 5 , 5
        }
    }
}
