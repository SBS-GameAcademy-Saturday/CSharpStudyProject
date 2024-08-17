using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// 함수
    /// 목표: 특정 작업을 수행하는 코드 블록을 정의하고 호출한다.
    /// 
    /// 함수(Function) 설명:
    /// 
    /// 함수 정의: 함수를 정의할 때는 반환 타입, 함수 이름, 매개변수 목록을 명시해야 합니다. 
    /// 위 예제에서 PrintMessage는 함수 이름이며, void는 이 함수가 값을 반환하지 않는다는 것을 의미합니다. 
    /// string message는 이 함수가 문자열 타입의 매개변수 message를 받는다는 것을 나타냅니다.
    /// 
    /// 함수 본문: 
    /// 중괄호 {} 안에는 함수가 호출될 때 실행될 코드를 작성합니다. 
    /// PrintMessage 함수에서는 전달받은 message를 콘솔에 출력하는 작업을 수행합니다.
    /// 
    /// 함수 호출: 
    /// 함수를 호출하기 위해서는 함수 이름과 함께 괄호 안에 필요한 매개변수를 전달합니다. 
    /// Run 메소드 내에서 PrintMessage("Hello, World!");를 호출함으로써, 
    /// "Hello, World!" 문자열이 PrintMessage 함수로 전달되고, 해당 문자열이 콘솔에 출력됩니다.
    /// 
    /// 함수의 장점:
    /// 1, 코드 재사용: 함수를 정의하면 동일한 코드를 여러 번 작성하지 않고도, 
    ///                 필요할 때마다 해당 함수를 호출함으로써 코드를 재사용할 수 있습니다.
    ///                 
    /// 2, 모듈성: 프로그램을 작은 단위의 태스크로 분할하여 각 태스크를 함수로 정의함으로써, 
    ///             프로그램의 구조를 보다 명확하게 할 수 있습니다.
    ///             
    /// 3, 유지 보수: 함수를 사용하면 프로그램의 특정 부분만을 수정해도 
    ///             다른 부분에 영향을 주지 않고 유지 보수를 쉽게 할 수 있습니다.
    ///             
    /// 함수는 프로그래밍에서 기본적이면서도 중요한 개념입니다. 
    /// C#을 비롯한 많은 프로그래밍 언어에서 함수는 프로그램의 기본 구성 요소 중 하나로, 
    /// 효율적이고 체계적인 프로그램 개발을 위해 필수적으로 사용됩니다.
    /// 
    /// </summary>
    public class Class8
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static string GetGreeting(string name)
        {
            return "Hello, " + name + "!";
        }

        public void Run()
        {
            PrintMessage("Hello, World!");
        }
    }
}