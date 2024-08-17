using System;

namespace CSharp_ProgramingStudy.Chapter4_Methods
{
  /// <summary>
  /// 메서드의 반환값 (Return Values) 학습 자료
  /// 
  /// 목표: 메서드가 작업을 수행한 후 결과를 호출자에게 반환하는 방식을 이해한다.
  /// 
  /// 메서드 반환값(Return Value) 설명:
  /// 
  /// 1. 반환값이란?
  ///    - 메서드가 작업을 수행한 후 결과를 호출자에게 반환하는 값을 의미합니다.
  ///    - 메서드의 반환값은 메서드의 반환 타입으로 지정됩니다.
  ///    - 반환값은 메서드 내에서 `return` 키워드를 사용하여 반환됩니다.
  ///    - 반환값이 없는 경우에는 메서드의 반환 타입을 `void`로 지정하며, `return` 키워드 없이 메서드를 종료합니다.
  /// 
  /// 2. 반환값의 역할:
  ///    - 반환값은 메서드의 결과를 호출한 코드로 전달하는 역할을 합니다.
  ///    - 이를 통해 메서드의 계산 결과나 상태를 외부에 알릴 수 있습니다.
  /// 
  /// 3. 반환값이 있는 메서드 예제:
  ///    - 아래 예제에서는 두 개의 정수를 더한 결과를 반환하는 `Add` 메서드를 정의합니다.
  ///    - `Add` 메서드는 `int` 타입의 반환값을 가지며, 두 정수를 더한 결과를 호출자에게 반환합니다.
  /// 
  /// 4. 반환값이 없는 메서드 예제:
  ///    - 반환값이 없는 메서드는 `void`를 반환 타입으로 지정하고, 특정 작업을 수행한 후 결과를 반환하지 않습니다.
  /// </summary>
  public class Class3
  {
    /// <summary>
    /// 두 정수를 더한 결과를 반환하는 메서드
    /// </summary>
    /// <param name="a">첫 번째 정수</param>
    /// <param name="b">두 번째 정수</param>
    /// <returns>두 정수의 합을 반환</returns>
    public int Add(int a, int b)
    {
      // 두 정수를 더한 결과를 반환
      return a + b;
    }

    /// <summary>
    /// 반환값이 없는 메서드 (void 반환 타입)
    /// </summary>
    /// <param name="message">출력할 메시지</param>
    public void PrintMessage(string message)
    {
      // 메시지를 출력하고, 반환값 없이 종료
      Console.WriteLine(message);
    }

    /// <summary>
    /// 메서드의 반환값을 사용하여 결과를 출력하는 예제
    /// </summary>
    public void Run()
    {
      // Add 메서드를 호출하고, 반환된 결과를 sum 변수에 저장
      int sum = Add(3, 7);
      // 반환된 결과 출력
      Console.WriteLine($"Sum: {sum}"); // 출력: Sum: 10

      // PrintMessage 메서드를 호출
      PrintMessage("Hello, World!"); // 출력: Hello, World!
    }
  }
}
