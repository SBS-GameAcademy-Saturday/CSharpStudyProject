using System;

namespace CSharp_ProgramingStudy.Chapter4_Methods
{
  /// <summary>
  /// 선택적 매개변수와 명명된 매개변수 (Optional and Named Parameters) 학습 자료
  /// 
  /// 목표: 메서드 호출 시 일부 매개변수를 생략하거나, 매개변수의 이름을 명시하여 호출하는 방법을 이해한다.
  /// 
  /// 선택적 매개변수 (Optional Parameters) 설명:
  /// 
  /// 1. 선택적 매개변수란?
  ///    - 메서드를 호출할 때 모든 매개변수를 전달할 필요가 없는 경우, 
  ///      기본값을 가진 선택적 매개변수를 사용할 수 있습니다.
  ///    - 선택적 매개변수는 메서드 선언 시 기본값을 지정할 수 있으며, 
  ///      호출자가 해당 매개변수를 생략하면 기본값이 사용됩니다.
  ///    - 선택적 매개변수는 항상 매개변수 목록의 마지막에 위치해야 합니다.
  /// 
  /// 명명된 매개변수 (Named Parameters) 설명:
  /// 
  /// 2. 명명된 매개변수란?
  ///    - 메서드를 호출할 때 매개변수의 이름을 명시적으로 지정하여 호출할 수 있는 기능입니다.
  ///    - 매개변수의 순서와 상관없이 이름을 지정하여 값을 전달할 수 있습니다.
  ///    - 명명된 매개변수는 선택적 매개변수와 함께 사용되어 가독성을 높이고, 
  ///      특정 매개변수만을 전달하는 데 유용합니다.
  /// 
  /// 3. 선택적 매개변수와 명명된 매개변수 예제:
  ///    - 아래의 예제에서는 기본 메시지를 가지는 `PrintMessage` 메서드를 정의하고, 
  ///      선택적 매개변수와 명명된 매개변수를 사용하여 메서드를 호출합니다.
  /// </summary>
  public class Class5
  {
    /// <summary>
    /// 메시지를 출력하는 메서드, 기본 메시지를 가짐
    /// </summary>
    /// <param name="message">출력할 메시지, 기본값은 "Default Message"</param>
    public void PrintMessage(string message = "Default Message")
    {
      Console.WriteLine(message);
    }

    /// <summary>
    /// 사용자 정보를 출력하는 메서드, 선택적 매개변수와 명명된 매개변수를 포함
    /// </summary>
    /// <param name="name">사용자의 이름</param>
    /// <param name="age">사용자의 나이, 기본값은 0</param>
    /// <param name="country">사용자의 국가, 기본값은 "Unknown"</param>
    public void PrintUserInfo(string name, int age = 0, string country = "Unknown")
    {
      Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }

    /// <summary>
    /// 선택적 매개변수와 명명된 매개변수를 사용하는 예제 메서드
    /// </summary>
    public void Run()
    {
      // 선택적 매개변수를 사용하여 메서드 호출
      PrintMessage();  // 출력: Default Message
      PrintMessage("Custom Message");  // 출력: Custom Message

      // 명명된 매개변수를 사용하여 메서드 호출
      PrintUserInfo(name: "Alice", age: 25, country: "USA");  // 출력: Name: Alice, Age: 25, Country: USA
      PrintUserInfo(name: "Bob", country: "UK");  // 출력: Name: Bob, Age: 0, Country: UK
      PrintUserInfo("Charlie");  // 출력: Name: Charlie, Age: 0, Country: Unknown
    }
  }
}
