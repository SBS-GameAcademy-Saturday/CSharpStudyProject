
using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// Immutable String (불변 문자열) 학습 자료
  /// 
  /// C#에서 문자열이 불변(immutable) 객체임을 이해하는 것이 중요합니다.
  /// 불변 객체는 생성된 이후에 그 값을 변경할 수 없습니다.
  /// 문자열을 변경하는 것처럼 보이는 작업은 실제로는 새로운 문자열 객체를 생성하는 것입니다.
  /// </summary>
  public class Class5
  {
    public void Run()
    {
      // 원래 문자열 생성
      string original = "Hello";
      Console.WriteLine($"원래 문자열: {original}"); // 출력: Hello

      // 문자열에 " World" 추가 (새로운 문자열 객체가 생성됨)
      string modified = original + " World";
      Console.WriteLine($"수정된 문자열: {modified}"); // 출력: Hello World

      // 원래 문자열은 여전히 변경되지 않았음을 확인
      Console.WriteLine($"수정 후 원래 문자열: {original}"); // 출력: Hello

      // 문자열이 불변이기 때문에, 원래 문자열은 변경되지 않았습니다.
      // 수정된 문자열은 실제로 새로운 문자열 객체입니다.

      // 추가 설명:
      // C#에서 문자열(string)은 불변(immutable) 객체입니다.
      // 이는 한 번 생성된 문자열 객체의 내용을 변경할 수 없음을 의미합니다.
      // 문자열을 변경하는 것처럼 보이는 작업(예: 문자열 연결, 부분 문자열 변경)은
      // 실제로는 새로운 문자열 객체를 생성하고, 기존의 문자열은 그대로 유지됩니다.

      // 메모리 측면:
      // 문자열이 불변이기 때문에, 각 수정 작업은 새로운 메모리 공간에 문자열을 할당합니다.
      // 이는 문자열의 빈번한 수정이 필요한 경우 성능과 메모리 사용 측면에서 비효율적일 수 있습니다.
      // 이 경우, StringBuilder를 사용하여 문자열을 효율적으로 조작하는 것이 좋습니다.
    }
  }
}
