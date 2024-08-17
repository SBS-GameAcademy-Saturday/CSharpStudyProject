using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter3_OOP
{
    /// <summary>
    /// 문자열 둘러보기
    /// 목표: C#에서 문자열을 다루는 다양한 방법과 문자열 관련 기능을 이해한다.
    /// 
    /// C#에서 문자열은 System.String 클래스를 사용하여 다룹니다. 
    /// 이 클래스는 문자 데이터를 저장하고 관리하는 데 사용되며, 
    /// 다양한 속성과 메서드를 제공하여 문자열을 조작할 수 있게 합니다. 
    /// 문자열은 변경 불가능(immutable)하므로, 
    /// 문자열을 조작하는 메서드들은 원본 문자열을 변경하는 대신 새로운 문자열 인스턴스를 반환합니다.
    /// 
    /// 문자열 기본
    /// 문자열 초기화: 문자열 변수는 큰따옴표("")를 사용하여 초기화할 수 있습니다.
    /// </summary>
    public class Class10
    {
        public void Run()
        {
            // 문자열 초기화 및 문자열 보간
            string name = "John";
            Console.WriteLine($"Hello {name}!"); // "Hello John!"

            // 문자열 길이
            Console.WriteLine(name.Length); // 4

            // 문자열 대소문자 변환
            Console.WriteLine(name.ToUpper()); // "JOHN"
            Console.WriteLine(name.ToLower()); // "john"

            // 문자열 포함 여부
            Console.WriteLine(name.Contains("oh")); // True

            // 문자열 비교
            Console.WriteLine(name.Equals("John")); // True
            Console.WriteLine(name == "John"); // True

            // 문자열 분할
            string data = "apple,orange,banana";
            string[] fruits = data.Split(',');
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            // apple
            // orange
            // banana

            // 문자열 치환
            string replacedString = name.Replace("John", "Jane");
            Console.WriteLine(replacedString); // "Jane"

            // 문자열 잘라내기
            string substring = name.Substring(1, 2);
            Console.WriteLine(substring); // "oh"

            // 문자열 공백 처리
            string greeting = "   Hello World!   ";
            Console.WriteLine($"'{greeting.Trim()}'"); // "'Hello World!'"
            Console.WriteLine($"'{greeting.TrimStart()}'"); // "'Hello World!   '"
            Console.WriteLine($"'{greeting.TrimEnd()}'"); // "'   Hello World!'"
        }
    }
}