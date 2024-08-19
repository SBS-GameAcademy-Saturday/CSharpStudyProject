using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 문자열 데이터 타입의 사용과 문자열 관련 기본 연산을 이해한다.
    /// 목표: 문자열 데이터 타입을 효과적으로 사용하고, 문자열 연결, 문자열 길이 확인, 문자열 내 특정 문자 접근 등의 기본적인 문자열 연산을 수행하는 방법을 배운다.
    /// 내용:
    /// - 문자열 연결: + 연산자를 사용하여 두 개 이상의 문자열을 하나로 결합한다.
    /// - 문자열 길이: Length 속성을 사용하여 문자열의 길이(문자 수)를 확인한다.
    /// - 문자열 접근: [] 인덱서를 사용하여 문자열 내의 특정 위치에 있는 문자에 접근할 수 있다.
    /// 이 클래스는 문자열을 생성, 연결, 조작하는 방법을 실제 예제를 통해 보여준다.
    /// 
    /// 
    /// 문자열 연산 설명:
    /// 문자열 연결: + 연산자를 사용해 두 개 이상의 문자열을 결합하여 새로운 문자열을 생성할 수 있습니다. 
    /// 이 방법은 간단한 문자열 결합에 유용합니다.
    /// 
    /// 문자열 길이: Length 속성을 통해 문자열에 포함된 문자의 개수를 반환받을 수 있습니다. 
    /// 이는 문자열 처리 시 문자열의 크기를 알아야 할 때 유용합니다.
    /// 
    /// 문자열 접근: [index] 인덱서를 사용하여 문자열 내의 특정 위치에 있는 문자에 접근할 수 있습니다. 
    /// 인덱스는 0부터 시작하여 문자열의 길이 - 1까지입니다.
    /// 
    /// 문자열을 다루는 기능은 사용자 입력 처리, 파일 읽기/쓰기, 
    /// 네트워크 통신 등 다양한 프로그래밍 상황에서 필수적입니다. 
    /// C#은 문자열을 처리하기 위한 풍부한 라이브러리와 메서드를 제공하여 
    /// 개발자가 효율적으로 문자열 데이터를 조작할 수 있도록 지원합니다.
    /// 
    /// </summary>
    public class Class_7
    {

        public void Run()
        {
            // 두 문자열을 연결하여 새 문자열 생성
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");

            // 문자열의 길이 확인
            Console.WriteLine($"Length of FullName: {fullName.Length}");

            // 문자열 내 특정 문자에 접근
            char firstLetter = fullName[0];
            Console.WriteLine($"First letter of FullName: {firstLetter}");
        }
    }
}
