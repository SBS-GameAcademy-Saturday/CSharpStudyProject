using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 변수와 데이터 형식에 대한 학습
    /// 목표: C#에서 사용되는 다양한 데이터 형식의 개념과 사용법을 이해하고, 변수를 선언하고 사용하는 방법을 학습한다.
    /// 내용: 기본 데이터 형식 소개(정수, 부동 소수점, 문자, 문자열, 불리언), 
    /// 값 형식과 참조 형식의 차이, 변수 선언, 초기화, 사용
    /// </summary>
    public class DataAndVariables
    {
        public void DemonstrateDataTypesAndVariables()
        {
            // 기본 데이터 형식의 변수 선언과 초기화

            // 정수형 변수 선언과 초기화
            int myInt = 5;
            Console.WriteLine($"정수형: {myInt}");

            // 부동 소수점 변수 선언과 초기화
            float myFloat = 5.99f;
            Console.WriteLine($"부동 소수점: {myFloat}");

            // 문자형 변수 선언과 초기화
            char myChar = 'A';
            Console.WriteLine($"문자: {myChar}");

            // 문자열 변수 선언과 초기화
            string myText = "Hello";
            Console.WriteLine($"문자열: {myText}");

            // 불리언형 변수 선언과 초기화
            bool myBool = true;
            Console.WriteLine($"불리언: {myBool}");

            // 추가 변수 선언과 초기화
            int age = 30;
            string name = "John";
            Console.WriteLine($"나이: {age}, 이름: {name}");
        }
    }

    // 연습문제
    // class Exercise
    // {
    //     static void Main(string[] args)
    //     {
    //         // 문제에 대한 변수 선언과 초기화
    //         int number = 100;
    //         double pi = 3.14;
    //         char letter = 'H';
    //         string phrase = "C# is fun";
    //         bool truthValue = true;

    //         Console.WriteLine($"정수: {number}, 원주율: {pi}, 문자: {letter}, 문구: {phrase}, 진리값: {truthValue}");
    //     }
    // }
}
