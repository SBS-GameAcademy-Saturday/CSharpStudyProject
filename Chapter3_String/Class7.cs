using System;

namespace Chapter3_String
{
  /// <summary>
  /// Escape Sequences (이스케이프 시퀀스) 학습 자료
  /// 
  /// 이스케이프 시퀀스는 문자열 내에서 특수 문자를 표현하기 위해 사용됩니다.
  /// 예를 들어, `\n`은 줄 바꿈, `\t`는 탭을 나타냅니다.
  /// 이러한 이스케이프 시퀀스를 사용하여 문자열에 특수 문자를 포함시킬 수 있습니다.
  /// </summary>
  public class Class7
  {
    public void Run()
    {
      // 1. 파일 경로를 표현하기 위한 이스케이프 시퀀스 사용
      // 백슬래시(\)는 이스케이프 시퀀스에서 특별한 의미를 가지기 때문에,
      // 파일 경로와 같은 문자열에서 백슬래시를 나타내려면 두 번 써야 합니다.
      string path = "C:\\Users\\John\\Documents";
      Console.WriteLine($"파일 경로: {path}");  // 출력: C:\Users\John\Documents

      // 2. 큰따옴표를 포함한 문자열 표현
      // 큰따옴표(")는 문자열을 정의하는 데 사용되므로, 문자열 내에서 큰따옴표를 포함하려면 이스케이프 시퀀스를 사용해야 합니다.
      string quote = "He said, \"Hello World!\"";
      Console.WriteLine($"인용구: {quote}"); // 출력: He said, "Hello World!"

      // 3. 줄 바꿈과 탭을 포함한 문자열 표현
      // \n은 줄 바꿈을, \t는 탭을 나타냅니다.
      string multiLineText = "First Line\nSecond Line\n\tIndented Line";
      Console.WriteLine("줄 바꿈과 탭 사용:");
      Console.WriteLine(multiLineText);
      // 출력:
      // First Line
      // Second Line
      //     Indented Line

      // 추가 설명:
      // 이스케이프 시퀀스는 문자열 내에서 특수 문자를 포함하기 위해 사용됩니다.
      // 주요 이스케이프 시퀀스:
      // - \n: 줄 바꿈
      // - \t: 탭
      // - \\: 백슬래시
      // - \": 큰따옴표
      // - \': 작은따옴표
      // 이러한 이스케이프 시퀀스를 사용하면, 문자열에 특수 문자를 포함시켜 보다 유연한 문자열 처리가 가능합니다.
    }
  }
}
