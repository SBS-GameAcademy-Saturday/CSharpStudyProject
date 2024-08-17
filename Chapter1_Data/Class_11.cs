using System;

namespace Chapter1_Data
{
    /// <summary>
    /// C#에서 제공하는 비교 연산자의 사용법을 이해한다.
    /// 목표: 동등, 부등, 크기 비교 연산자를 사용하여 조건을 평가하는 방법을 배운다.
    /// 내용:
    /// - 동등(==): 두 값이 같은지 비교한다.
    /// - 부등(!=): 두 값이 다른지 비교한다.
    /// - 크기 비교(>, <, >=, <=): 두 값의 크기를 비교한다.
    /// 이 클래스는 비교 연산자를 사용한 기본적인 예제를 제공하며, 이를 통해 조건 평가 방법을 보여준다.
    /// 
    /// 비교 연산 설명:
    /// 동등(==): 두 피연산자가 같으면 true를 반환합니다.
    /// 부등(!=): 두 피연산자가 다르면 true를 반환합니다.
    /// 크다(>): 왼쪽 피연산자가 오른쪽 피연산자보다 크면 true를 반환합니다.
    /// 작다(<): 왼쪽 피연산자가 오른쪽 피연산자보다 작으면 true를 반환합니다.
    /// 크거나 같다(>=): 왼쪽 피연산자가 오른쪽 피연산자보다 크거나 같으면 true를 반환합니다.
    /// 작거나 같다(<=): 왼쪽 피연산자가 오른쪽 피연산자보다 작거나 같으면 true를 반환합니다.
    /// 
    /// 비교 연산자는 프로그램의 로직을 결정하는 데 중요한 역할을 합니다. 
    /// 예를 들어, 사용자 입력이 기대하는 값과 일치하는지, 
    /// 어떤 값이 다른 값보다 큰지 또는 작은지 등을 평가할 때 사용됩니다. 
    /// 이러한 비교는 조건문(if, switch)과 반복문(while, for)에서 조건을 정의하는 데 필수적입니다.
    /// </summary>
    public class Class_11
    {
        public void Run()
        {
            // 비교 연산자 사용 예제
            bool isEqual = (10 == 5); // 같다
            bool isNotEqual = (10 != 5); // 다르다
            bool isGreaterThan = (10 > 5); // 크다
            bool isLessThan = (10 < 5); // 작다
            bool isGreaterThanOrEqual = (10 >= 5); // 크거나 같다
            bool isLessThanOrEqual = (10 <= 5); // 작거나 같다

            Console.WriteLine($"Is Equal: {isEqual}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Greater Than Or Equal: {isGreaterThanOrEqual}");
            Console.WriteLine($"Is Less Than Or Equal: {isLessThanOrEqual}");
        }

        // static void Main(string[] args)
        // {
        //     new Class_11().Run();
        // }
    }
}
