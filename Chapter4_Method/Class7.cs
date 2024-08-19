using System;

namespace CSharp_ProgramingStudy.Chapter4_Methods
{
  /// <summary>
  /// 클로저 (Closures) 학습 자료
  /// 
  /// 목표: 메서드가 자신이 정의된 환경(변수)과 함께 저장되어 다른 메서드에서 호출될 수 있는 기능을 이해한다.
  /// 
  /// 클로저(Closures) 설명:
  /// 
  /// 1. 클로저란?
  ///    - 클로저는 메서드(보통 람다 식 또는 익명 메서드)가 자신이 정의된 환경(변수들)을 
  ///      캡처하여 그 환경과 함께 저장되는 기능을 의미합니다.
  ///    - 클로저를 사용하면 메서드가 외부 범위의 변수에 접근하여, 
  ///      해당 변수를 메서드 내에서 사용할 수 있습니다.
  ///    - 캡처된 변수는 메서드가 호출될 때마다 그 상태를 유지합니다.
  /// 
  /// 2. 클로저의 주요 특징:
  ///    - **변수 캡처**: 클로저는 자신이 정의된 환경에서의 변수들을 캡처합니다. 
  ///      이 변수들은 클로저가 호출될 때마다 상태를 유지합니다.
  ///    - **지연 실행**: 클로저는 호출될 때까지 실행되지 않으며, 
  ///      호출될 때 비로소 캡처된 변수들을 사용하여 동작합니다.
  ///    - **코드 재사용**: 클로저는 코드의 일부를 매개변수로 전달하거나 
  ///      메서드로부터 반환하여 재사용할 수 있습니다.
  /// 
  /// 3. 클로저의 예제:
  ///    - 아래의 예제에서는 `CreateMultiplier` 메서드를 통해 
  ///      주어진 배수 값을 곱해주는 클로저를 생성하여 반환합니다.
  ///    - 생성된 클로저는 배수 값을 캡처하여, 나중에 호출될 때마다 이를 사용합니다.
  /// </summary>
  public class ClosuresExample
  {
    /// <summary>
    /// 주어진 배수 값을 사용하여 곱셈 연산을 수행하는 클로저를 생성하는 메서드
    /// </summary>
    /// <param name="multiplier">캡처할 배수 값</param>
    /// <returns>주어진 값에 배수를 곱하는 클로저</returns>
    public Func<int, int> CreateMultiplier(int multiplier)
    {
      // 클로저를 반환, multiplier는 클로저에 의해 캡처됨
      return x => x * multiplier;
    }

    /// <summary>
    /// 클로저를 사용하는 예제 메서드
    /// </summary>
    public void Run()
    {
      // 2배를 곱하는 클로저 생성
      var doubler = CreateMultiplier(2);
      // 5에 2를 곱한 결과 출력
      Console.WriteLine(doubler(5)); // 출력: 10

      // 3배를 곱하는 클로저 생성
      var tripler = CreateMultiplier(3);
      // 5에 3을 곱한 결과 출력
      Console.WriteLine(tripler(5)); // 출력: 15
    }
  }
}
