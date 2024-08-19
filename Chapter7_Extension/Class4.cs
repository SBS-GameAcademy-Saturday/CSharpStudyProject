using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Delegate (대리자)
    /// 목표: 메소드를 변수처럼 전달할 수 있게 해주는 대리자의 사용법을 학습한다.
    /// 
    /// 대리자(Delegate)는 C# 프로그래밍 언어에서 메서드를 변수처럼 전달할 수 있게 해주는 타입입니다. 
    /// 즉, 대리자는 메서드에 대한 참조를 캡슐화하는 객체로, 메서드를 인자로 다른 메서드에 전달하거나, 
    /// 메서드를 동적으로 할당하고 호출하는 데 사용됩니다. 
    /// 
    /// 이를 통해 프로그램에서 콜백 메서드를 구현하거나, 
    /// 이벤트 처리 같은 고급 프로그래밍 기법을 적용할 수 있습니다.
    /// 
    /// 대리자의 주요 특징:
    /// 1, 메서드 참조: 대리자는 하나 이상의 메서드를 참조할 수 있으며, 
    /// 대리자 타입에 맞는 시그니처(반환 타입과 매개 변수)를 가진 모든 메서드를 참조할 수 있습니다.
    /// 
    /// 2, 타입 안전성: 대리자는 특정 시그니처를 가진 메서드만 참조할 수 있어, 타입 안전성을 제공합니다. 
    /// 이는 대리자가 참조하는 메서드가 예상한 매개 변수와 반환 타입을 갖도록 강제합니다.
    /// 
    /// 3, 멀티캐스팅: 대리자는 여러 메서드를 참조할 수 있는 멀티캐스트 대리자의 형태로 사용될 수 있으며, 
    /// 이를 통해 이벤트 시스템을 구현할 수 있습니다.
    /// </summary>
    public class Class4
    {
        // 대리자 선언: void 반환 타입과 string 매개변수를 받는 메서드를 참조
        public delegate void ShowMessage(string message);

        // 출력할 메서드 정의
        static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }

        static void Run()
        {
            // 대리자를 통해 메서드를 참조
            ShowMessage showMessage = PrintToConsole;

            // 대리자를 사용하여 메서드 호출
            showMessage("Hello, this is a simple delegate example!"); // 출력: Hello, this is a simple delegate example!
        }
    }
}