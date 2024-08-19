using System;
using System.Text;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// StringBuilder 클래스 학습 자료
  /// 
  /// C#에서 문자열을 자주 변경해야 할 때는 `StringBuilder`를 사용하는 것이 더 효율적입니다.
  /// StringBuilder는 가변(mutable) 객체로, 메모리와 성능 측면에서 유리합니다.
  /// 문자열이 불변(immutable) 객체이기 때문에, 문자열을 반복해서 수정할 경우
  /// 새로운 문자열 객체가 계속 생성되어 메모리와 성능에 부정적인 영향을 줄 수 있습니다.
  /// 이런 경우, StringBuilder를 사용하면 문자열을 효율적으로 조작할 수 있습니다.
  /// </summary>
  public class Class6
  {
    public void Run()
    {
      // StringBuilder 객체 생성
      StringBuilder sb = new StringBuilder();

      // 문자열을 StringBuilder에 추가 (Append 메서드 사용)
      sb.Append("Hello");
      sb.Append(" ");
      sb.Append("World");

      // StringBuilder에 저장된 내용을 문자열로 변환
      string result = sb.ToString(); // "Hello World"
      Console.WriteLine(result); // 출력: Hello World

      // 추가 설명:
      // StringBuilder는 가변(mutable) 객체로, 문자열을 반복해서 수정하거나 추가할 때 유리합니다.
      // StringBuilder를 사용하지 않고 문자열을 계속해서 수정하면, 새로운 문자열 객체가 생성되기 때문에
      // 메모리와 성능 측면에서 비효율적일 수 있습니다.
      // StringBuilder는 이러한 문제를 해결하기 위해 설계된 클래스로, 특히 많은 문자열 변경 작업이 있을 때 사용됩니다.

      // 예를 들어, StringBuilder는 반복문에서 많은 문자열 연결 작업을 수행할 때 유용합니다:
      sb.Clear(); // StringBuilder 초기화

      for (int i = 0; i < 5; i++)
      {
        sb.Append("Line ");
        sb.Append(i);
        sb.AppendLine(); // 줄 바꿈 포함하여 추가
      }

      string resultLines = sb.ToString();
      Console.WriteLine(resultLines);
      // 출력:
      // Line 0
      // Line 1
      // Line 2
      // Line 3
      // Line 4
    }
  }
}
