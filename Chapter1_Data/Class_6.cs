using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 불리언 데이터 타입과 조건문에서의 사용을 이해한다.
    /// 목표: bool 타입의 기본 이해와 조건문에서의 활용 방법을 배운다.
    /// 내용:
    /// - true와 false 값: bool 타입은 논리적인 참(true) 또는 거짓(false)을 표현하는 데 사용된다. 
    /// 이는 프로그램의 조건부 로직을 구성하는 데 필수적이다.
    /// 
    /// - 불리언형 변수의 선언과 초기화: bool 키워드를 사용하여 불리언형 변수를 선언하고, 
    /// true 또는 false 값으로 초기화할 수 있다.
    /// 
    /// 이 클래스는 bool 타입 변수의 기본 사용 예를 제공하며, 
    /// 이를 통해 참과 거짓을 나타내는 방법을 보여준다.
    /// 
    /// 불리언(bool) 데이터 타입 설명:
    /// 기본 개념: bool 타입은 프로그래밍에서 가장 기본적인 데이터 타입 중 하나로, 
    /// 참(true) 또는 거짓(false)을 나타내는 데 사용됩니다.
    /// 
    /// 사용 예제: 조건문(if, while 등)에서 bool 타입의 변수를 사용하여 프로그램의 흐름을 제어할 수 있습니다. 
    /// 예를 들어, 어떤 조건이 참일 때만 특정 코드 블록을 실행하도록 할 수 있습니다.
    /// 
    /// 논리 연산: bool 타입의 변수는 논리 연산자(&&, ||, !)와 함께 사용되어 
    /// 복잡한 조건을 평가하는 데 사용될 수 있습니다.
    /// 불리언 타입은 프로그램의 결정을 내리고, 조건부 로직을 구현하는 데 있어 필수적인 요소입니다. 
    /// 간단하지만 매우 강력한 bool 타입은 프로그래밍의 다양한 상황에서 유용하게 사용됩니다.
    /// </summary>
    public class Class_6
    {
        // 불리언형 변수 선언과 초기화
        bool isCSharpFun = true;
        bool isFishTasty = false;

        public void CheckConditions()
        {
            if (isCSharpFun)
            {
                Console.WriteLine("Yes, C# is fun!");
            }

            if (!isFishTasty)
            {
                Console.WriteLine("No, fish is not tasty.");
            }
        }

        // static void Main(string[] args)
        // {
        //     new Class_8().CheckConditions();
        // }
    }
}
