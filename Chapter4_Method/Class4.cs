using System;

namespace CSharp_ProgramingStudy.Chapter4_CodeFlow
{
    /// <summary>
    /// 오버로딩 (Overloading) 학습 자료
    /// 
    /// 목표: 같은 이름의 함수를 다른 매개변수로 정의하여 사용하는 방법을 이해한다.
    /// 
    /// 오버로딩(Overloading)은 동일한 이름을 가진 메서드를 여러 개 정의하여, 
    /// 서로 다른 매개변수를 사용할 수 있게 하는 기능입니다. 
    /// 이를 통해 메서드의 이름을 재사용하고, 코드의 가독성과 유연성을 향상시킬 수 있습니다.
    /// 
    /// 오버로딩의 장점:
    /// 1. 유연성: 
    ///    - 다양한 타입의 인수에 대해 동일한 작업을 수행하는 여러 버전의 메서드를 제공할 수 있습니다.
    /// 
    /// 2. 가독성: 
    ///    - 유사한 기능을 수행하는 메서드들이 같은 이름을 공유하여, 코드의 목적을 더 명확하게 전달할 수 있습니다.
    /// 
    /// 3. 유지 보수: 
    ///    - 기능적으로 유사한 메서드들을 그룹화하여 유지 보수가 용이해집니다.
    /// 
    /// 오버로딩 규칙:
    /// 1. 오버로딩된 메서드는 매개변수의 타입, 개수, 또는 순서가 달라야 합니다.
    /// 2. 반환 타입, 접근 제한자, 매개변수의 이름은 오버로딩을 구분하는 데 사용되지 않습니다.
    /// 
    /// 오버로딩은 메서드를 다양한 상황에 맞게 여러 버전으로 제공할 수 있게 해줍니다. 
    /// 이를 통해 프로그램의 다양성과 유연성을 보장하며, 
    /// 개발자가 보다 효율적으로 코드를 작성할 수 있게 돕습니다.
    /// </summary>
    public class Class4
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

        /// <summary>
        /// 두 개의 정수 매개변수를 받아 합을 출력하는 Print 메서드
        /// </summary>
        /// <param name="number1">첫 번째 숫자</param>
        /// <param name="number2">두 번째 숫자</param>
        void Print(int number1, int number2)
        {
            Console.WriteLine($"Sum: {number1 + number2}");
        }

        /// <summary>
        /// 두 개의 문자열을 받아 합친 결과를 출력하는 Print 메서드
        /// </summary>
        /// <param name="message1">첫 번째 메시지</param>
        /// <param name="message2">두 번째 메시지</param>
        void Print(string message1, string message2)
        {
            Console.WriteLine($"Combined Message: {message1} {message2}");
        }

        /// <summary>
        /// 배열을 받아 배열의 모든 원소를 출력하는 Print 메서드
        /// </summary>
        /// <param name="numbers">출력할 정수 배열</param>
        void Print(int[] numbers)
        {
            Console.Write("Array Elements: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 오버로딩된 Print 메서드를 실행하는 예제 메서드
        /// </summary>
        public void Run()
        {
            // 오버로딩된 Print 메서드 호출 예제
            Print(123);                // 출력: Number: 123
            Print("Hello!");            // 출력: Message: Hello!
            Print(5, 10);               // 출력: Sum: 15
            Print("Good", "Morning");   // 출력: Combined Message: Good Morning
            Print(new int[] { 1, 2, 3, 4, 5 }); // 출력: Array Elements: 1 2 3 4 5
        }
    }
}
