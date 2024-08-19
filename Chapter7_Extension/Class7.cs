using System;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Lambda (람다식)
    /// 람다식은 C#에서 익명 함수를 생성하기 위한 간결한 방법을 제공합니다.
    /// 람다식은 매개변수 목록, => 연산자, 그리고 식 또는 문의 본문으로 구성됩니다.
    /// 이를 통해 이벤트 핸들러, LINQ 쿼리 등에서 사용할 수 있는 간단하고 강력한 방식으로 대리자 또는 식 트리를 정의할 수 있습니다.
    ///
    /// 주요 특징:
    /// - 익명성: 람다식은 이름이 없으며, 주로 메서드 인자로 전달하거나 변수에 할당하는 등의 방식으로 사용됩니다.
    /// - 간결성: 복잡한 함수를 한 줄의 코드로 간결하게 표현할 수 있으며, 코드의 가독성을 높입니다.
    /// - 유연성: 코드를 데이터와 같이 전달할 수 있어, 프로그래밍 패러다임을 유연하게 만들어 줍니다.
    ///
    /// 사용 예:
    /// 람다식은 (매개변수 목록) => 식 또는 (매개변수 목록) => { 문장들; } 형태를 가질 수 있습니다.
    /// 예를 들어, 두 수를 더하는 람다식: Func<int, int, int> add = (a, b) => a + b;
    /// 여기서 Func<int, int, int>는 두 개의 int 매개변수를 받고 int를 반환하는 대리자 타입입니다.
    ///
    /// 활용:
    /// - 람다식은 LINQ 쿼리, 이벤트 핸들러의 등록, 타이머의 콜백 함수 등 다양한 곳에서 활용됩니다.
    /// - 특히, LINQ 쿼리에서 람다식을 사용하면 컬렉션에 저장된 데이터를 처리하는 복잡한 쿼리를 간결하고 읽기 쉬운 코드로 작성할 수 있습니다.
    /// </summary>
    public class Class6
    {
        public void Run()
        {
            // 1. 두 숫자를 더하는 간단한 람다식
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"5 + 3 = {add(5, 3)}"); // 출력: 5 + 3 = 8

            // 2. 문자열 리스트에서 특정 조건에 맞는 문자열 필터링
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };
            List<string> longFruits = fruits.Where(f => f.Length > 5).ToList();
            Console.WriteLine("Fruits with more than 5 characters:");
            longFruits.ForEach(f => Console.WriteLine(f)); // 출력: Banana, Cherry

            // 3. 리스트 정렬을 위한 람다식
            List<int> numbers = new List<int> { 5, 3, 8, 1, 2 };
            numbers.Sort((x, y) => x.CompareTo(y)); // 오름차순 정렬
            Console.WriteLine("Sorted numbers:");
            numbers.ForEach(n => Console.WriteLine(n)); // 출력: 1, 2, 3, 5, 8

            // 4. 람다식을 사용한 간단한 조건문
            Func<int, bool> isEven = num => num % 2 == 0;
            Console.WriteLine($"4 is even: {isEven(4)}"); // 출력: 4 is even: True
            Console.WriteLine($"7 is even: {isEven(7)}"); // 출력: 7 is even: False

            // 5. 이벤트 핸들러에 람다식 사용
            Action onButtonClick = () => Console.WriteLine("Button clicked!");
            onButtonClick(); // 이벤트가 발생했을 때 호출되는 코드, 출력: Button clicked!

            // 6. 컬렉션의 모든 요소에 대해 작업 수행
            List<int> values = new List<int> { 1, 2, 3, 4, 5 };
            values.ForEach(value => Console.WriteLine($"Value: {value}")); // 각 요소 출력

            // 7. 문자열 조작 예제
            Func<string, string> toUpperCase = s => s.ToUpper();
            Console.WriteLine(toUpperCase("hello")); // 출력: HELLO

            // 8. 두 문자열을 결합하는 람다식
            Func<string, string, string> combine = (s1, s2) => s1 + " " + s2;
            Console.WriteLine(combine("Hello", "World")); // 출력: Hello World

            // 9. 리스트에서 특정 숫자보다 큰 값 찾기
            List<int> numbersList = new List<int> { 10, 20, 30, 40, 50 };
            List<int> greaterThan25 = numbersList.Where(n => n > 25).ToList();
            Console.WriteLine("Numbers greater than 25:");
            greaterThan25.ForEach(n => Console.WriteLine(n)); // 출력: 30, 40, 50

            // 10. 컬렉션의 합계 구하기
            Func<List<int>, int> sumNumbers = nums => nums.Sum();
            Console.WriteLine($"Sum of numbers: {sumNumbers(numbersList)}"); // 출력: Sum of numbers: 150
        }
    }
}
