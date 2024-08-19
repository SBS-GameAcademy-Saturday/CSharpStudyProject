using System;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
  /// <summary>
  /// Action과 Func는 대리자(delegate)를 사용하는 강력하고 유연한 방식을 제공합니다.
  /// 이 두 가지는 특히 람다 표현식과 함께 사용할 때 코드를 간결하고 명확하게 만들어 주며,
  /// 개발자가 보다 함수적인 접근 방식을 취할 수 있도록 도와줍니다.
  /// 아래에서는 Action과 Func의 기본적인 개념, 차이점, 그리고 사용 예제를 다룹니다.

  /// Action 대리자는 반환 값이 없는 메서드를 캡슐화합니다.
  /// 다시 말해, Action은 void를 반환하는 메서드에 사용됩니다.
  /// Action은 최대 16개의 매개변수를 받을 수 있습니다. 매개변수가 없는 경우부터 시작하여,
  /// Action<T1, T2, ..., T16>까지 다양한 형태를 지원합니다.
  /// 기본 사용 예:
  ///    Action greet = () => Console.WriteLine("Hello, World!"); // 반환 값이 없는 메서드를 캡슐화한 Action 대리자
  ///    greet(); // "Hello, World!" 출력
  // 매개변수가 있는 사용 예:
  ///    Action<string, string> printNames = (firstName, lastName) =>
  ///    Console.WriteLine($"First name: {firstName}, Last name: {lastName}"); // 두 개의 매개변수를 받는 Action 대리자
  ///    printNames("Jane", "Doe"); // "First name: Jane, Last name: Doe" 출력

  /// 반면, Func 대리자는 반환 값이 있는 메서드를 캡슐화합니다.
  /// Func의 마지막 제네릭 타입은 항상 메서드의 반환 타입을 나타냅니다.
  /// Func 역시 최대 16개의 매개변수까지 지원하고, Func<TResult>부터 Func<T1, T2, ..., T16, TResult>까지 다양한 조합을 가질 수 있습니다.

  /// 기본 사용 예:
  ///   Func<int, int, int> add = (x, y) => x + y; // 두 정수를 더하고 그 결과를 반환하는 Func 대리자
  ///   int result = add(5, 3); // 5 + 3 = 8
  ///   Console.WriteLine(result);  // 출력: 8
  /// 
  /// 매개변수가 여러 개인 사용 예:
  /// 
  ///   Func<double, double, double, double> volume = (x, y, z) => x * y * z; // 세 개의 double 타입 값을 곱하여 부피를 계산하는 Func 대리자
  ///   double boxVolume = volume(3.0, 4.5, 5.0); // 3.0 * 4.5 * 5.0 = 67.5
  ///   Console.WriteLine(boxVolume);  // 출력: 67.5
  /// 
  /// 차이점:
  /// Action과 Func의 주된 차이점은 Action이 반환 값을 갖지 않는다는 것이고,
  /// Func는 반드시 반환 값을 요구한다는 점입니다.
  /// 이는 두 대리자를 사용하는 상황에 영향을 미칩니다.
  /// 예를 들어, 어떤 작업을 수행만 하고 결과를 반환할 필요가 없는 경우 Action을 사용하며,
  /// 계산이 필요하고 그 결과를 반환해야 할 때는 Func을 사용합니다.
  /// </summary>
  class Class5
  {

    // 인사를 출력하는 메서드 (Action 예제)
    static void GreetMessage()
    {
      Console.WriteLine("Hello, World!");
    }

    // 이름을 출력하는 메서드 (Action 예제)
    static void PrintName(string name)
    {
      Console.WriteLine("Name: " + name);
    }

    // 두 숫자를 더하는 메서드 (Func 예제)
    static int AddNumbers(int x, int y)
    {
      return x + y;
    }

    // 숫자가 짝수인지 홀수인지 확인하는 메서드 (Func 예제)
    static string CheckOddEven(int number)
    {
      if (number % 2 == 0)
        return "Even";
      else
        return "Odd";
    }

    static void Run()
    {
      // Action 예제: 인사를 출력하는 메서드를 참조하는 대리자
      Action greet = new Action(GreetMessage);
      greet(); // "Hello, World!" 출력

      // Action 예제: 이름을 출력하는 메서드를 참조하는 대리자
      Action<string> printName = new Action<string>(PrintName);
      printName("Alice"); // "Name: Alice" 출력

      // Func 예제: 두 숫자를 더하는 메서드를 참조하는 대리자
      Func<int, int, int> add = new Func<int, int, int>(AddNumbers);
      int sum = add(2, 3); // 2 + 3 = 5
      Console.WriteLine("Sum: " + sum); // "Sum: 5" 출력

      // Func 예제: 숫자가 짝수인지 홀수인지 확인하는 메서드를 참조하는 대리자
      Func<int, string> checkOddEven = new Func<int, string>(CheckOddEven);
      string result = checkOddEven(4); // 4는 짝수
      Console.WriteLine("4 is: " + result); // "4 is: Even" 출력
    }
  }
}
