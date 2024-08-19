using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// Raw 문자열 리터럴 학습 자료 (C# 11 이상)
  /// 
  /// C# 11에서는 여러 줄의 텍스트를 포함할 수 있는 raw 문자열 리터럴이 도입되었습니다.
  /// 시작과 끝에 삼중 따옴표("""")를 사용하여 이스케이프 시퀀스 없이도 그대로 문자열을 작성할 수 있습니다.
  /// Raw 문자열 리터럴은 줄 바꿈, 탭, 백슬래시 등과 같은 특수 문자를 포함한 텍스트를 더 쉽게 작성할 수 있게 해줍니다.
  /// </summary>
  public class Class8
  {
    public void Run()
    {
      // Raw 문자열 리터럴을 사용한 예제
      string rawString = """
            Line 1
            Line 2
            Line 3
            """;

      // Raw 문자열 리터럴은 시작과 끝에 삼중 따옴표("""")를 사용합니다.
      // 이 리터럴은 여러 줄의 텍스트를 그대로 포함할 수 있으며, 이스케이프 시퀀스를 사용할 필요가 없습니다.

      Console.WriteLine("Raw 문자열 리터럴 출력:");
      Console.WriteLine(rawString);
      // 출력:
      // Line 1
      // Line 2
      // Line 3

      // 추가 설명:
      // Raw 문자열 리터럴은 특히 다음과 같은 상황에서 유용합니다:
      // - 여러 줄에 걸친 텍스트를 포함해야 할 때
      // - 이스케이프 시퀀스를 피하고 텍스트를 그대로 표현하고 싶을 때
      // - JSON, XML 등 복잡한 텍스트를 작성할 때

      // 예를 들어, JSON 문자열을 Raw 문자열 리터럴로 표현할 수 있습니다:
      string jsonString = """
            {
                "name": "John Doe",
                "age": 30,
                "isStudent": false,
                "address": {
                    "street": "123 Main St",
                    "city": "Anytown"
                }
            }
            """;

      Console.WriteLine("JSON 문자열:");
      Console.WriteLine(jsonString);
      // 출력:
      // {
      //     "name": "John Doe",
      //     "age": 30,
      //     "isStudent": false,
      //     "address": {
      //         "street": "123 Main St",
      //         "city": "Anytown"
      //     }
      // }

      // 이처럼 Raw 문자열 리터럴은 복잡한 문자열을 보다 쉽게 작성하고 읽기 좋게 만들 수 있습니다.
    }
  }
}
