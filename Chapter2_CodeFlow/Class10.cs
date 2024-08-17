using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// 오버로딩
    /// 목표: 같은 이름의 함수를 다른 매개변수로 정의하여 사용하는 방법을 이해한다.
    /// 
    /// 오버로딩을 통해 메서드의 이름을 재사용함으로써, 
    /// 유사한 작업을 수행하는 메서드 간의 연관성을 표현하고,
    /// 코드의 가독성을 향상시킨다.
    /// 오버로딩의 장점:
    /// 1, 유연성: 
    /// 오버로딩을 사용하면, 다양한 타입의 인수를 받을 수 있는 여러 버전의 메서드를 제공할 수 있습니다. 
    /// 이는 프로그램의 유연성을 크게 향상시킵니다.
    /// 
    /// 2, 가독성: 
    /// 유사한 기능을 수행하는 메서드들이 같은 이름을 공유함으로써, 
    /// 코드의 목적을 더 명확하게 전달할 수 있습니다. 
    /// 이는 코드의 가독성과 이해도를 높입니다.
    /// 
    /// 3, 유지 보수: 
    /// 기능적으로 유사한 메서드들이 오버로딩을 통해 함께 그룹화되므로, 
    /// 유지 보수가 용이해집니다.
    /// 
    /// 오버로딩 규칙:
    /// 1, 오버로딩된 메서드는 매개변수의 타입, 개수, 순서가 달라야 합니다.
    /// 2, 반환 타입, 접근 제한자, 매개변수의 이름은 오버로딩을 구분하는 데 사용되지 않습니다.
    /// 
    /// 오버로딩은 프로그래밍에서 매우 유용한 기능으로, 
    /// 메서드를 다양한 상황에 맞게 여러 버전으로 제공할 수 있게 해줍니다. 
    /// 이를 통해 프로그램의 다양성과 유연성을 보장하며, 
    /// 개발자가 보다 효율적으로 코드를 작성할 수 있게 돕습니다.
    /// </summary>
    public class Class10
    {
        /// <summary>
        /// 정수형 매개변수를 받는 Print 메서드
        /// </summary>
        /// <param name="number">출력할 숫자</param>
        void Print(int number)
        {
            Console.WriteLine($"Number: {number}");
        }

        /// <summary>
        /// 문자열 매개변수를 받는 Print 메서드
        /// </summary>
        /// <param name="message">출력할 메시지</param>
        void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void Run()
        {
            Print(123); // Number: 123
            Print("Hello!"); // Message: Hello!
        }
    }
}