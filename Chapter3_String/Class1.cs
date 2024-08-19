using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
    /// <summary>
    /// 문자열 포맷팅을 사용하여 데이터를 보기 좋게 표시하는 방법을 이해한다.
    /// 목표: 문자열 보간과 형식 지정자를 사용하여 복잡한 데이터를 보기 좋게 포맷팅하는 기술을 학습한다.
    /// 
    /// 내용:
    /// - 문자열 보간: $ 기호를 사용하여 문자열 내에 변수나 표현식의 값을 직접 삽입한다. 
    /// 이를 통해 복잡한 문자열을 쉽고 가독성 있게 구성할 수 있다.
    /// 
    /// - 형식 지정자 사용: 데이터를 특정 형식으로 표시하기 위해 형식 지정자를 사용한다. 
    /// 예를 들어, 숫자를 통화 형태로 표시하거나, 날짜를 특정 형식으로 포맷팅하는 데 사용된다.
    /// 
    /// 이 클래스는 문자열 보간을 사용한 간단한 문자열 포맷팅 예제를 보여준다.
    /// 
    /// 문자열 포맷팅 설명:
    /// 문자열 보간(String Interpolation): C# 6.0부터 추가된 기능으로, 
    /// $ 기호와 중괄호 {}를 사용하여 문자열 내에 직접 변수, 표현식, 형식 지정자를 삽입할 수 있습니다. 
    /// 이 방법은 코드의 가독성을 높이며, 복잡한 문자열을 쉽게 조합할 수 있게 합니다.
    /// 
    /// 형식 지정자(Format Specifiers): 데이터를 특정 형식에 맞게 포맷팅하고자 할 때 사용됩니다. 
    /// 예를 들어, 숫자를 통화 형태로 표시하거나, 소수점 이하의 자릿수를 제한하거나, 
    /// 날짜를 특정 형식으로 표시하는 데 사용할 수 있습니다.
    /// 
    /// 문자열 포맷팅 기법은 로깅, 사용자 인터페이스, 데이터 표시 등 다양한 상황에서 유용하게 사용됩니다. 
    /// C#의 문자열 보간과 형식 지정자를 활용하면, 코드 내에서 데이터를 보다 유연하고 효율적으로 표현할 수 있습니다.
    /// 
    /// </summary>
    public class Class_1
    {
        public void Run()
        {
            // 문자열 보간을 사용한 문자열 포맷팅
            string name = "John";
            int age = 30;
            string message = $"Name: {name}, Age: {age}";
            Console.WriteLine(message);

            // 형식 지정자를 사용한 문자열 포맷팅
            double pi = 3.14159265;
            string formattedPi = $"Pi is {pi:F2}"; // 소수점 아래 두 자리까지 표시
            Console.WriteLine(formattedPi);

            // 통화 형식 지정자 사용 예제
            decimal price = 199.99m;
            string formattedPrice = $"Price: {price:C}"; // 통화 형식으로 표시
            Console.WriteLine(formattedPrice);

            // 날짜 형식 지정자 사용 예제
            DateTime today = DateTime.Now;
            string formattedDate = $"Today is {today:yyyy-MM-dd}"; // "년-월-일" 형식으로 날짜 표시
            Console.WriteLine(formattedDate);

            // 정수에 대한 형식 지정자 사용 예제 (숫자에 대한 자리수 고정)
            int number = 1234;
            string formattedNumber = $"Number: {number:D8}"; // 8자리 숫자로 표시, 부족한 자리는 0으로 채움
            Console.WriteLine(formattedNumber);
        }
        // 출력 결과
        // Name: John, Age: 30
        // Pi is 3.14
        // Price: $199.99
        // Today is 2024-08-17
        // Number: 00001234

    }
}
