using System;
using System.Text.RegularExpressions;

namespace Chapter3_String
{
  /// <summary>
  /// Regular Expressions (정규 표현식) 학습 자료
  /// 
  /// 정규 표현식을 사용하여 문자열의 패턴을 검색, 일치, 변환할 수 있습니다.
  /// `System.Text.RegularExpressions` 네임스페이스를 사용하여 정규 표현식을 처리합니다.
  /// 정규 표현식은 복잡한 문자열 패턴을 정의하고 이를 기반으로 문자열을 검색하거나, 
  /// 일치하는 부분을 추출하거나, 문자열을 변환하는 데 매우 유용합니다.
  /// </summary>
  public class Class9
  {
    public void Run()
    {
      // 정규 표현식을 사용한 간단한 예제
      // 패턴: \d+ -> 하나 이상의 숫자와 일치하는 패턴
      string pattern = @"\d+";
      string input = "The price is 100 dollars";

      // Regex.Match 메서드를 사용하여 입력 문자열에서 패턴과 일치하는 부분을 찾습니다.
      Match match = Regex.Match(input, pattern);

      // 일치하는 부분이 있는지 확인하고, 있다면 해당 값을 출력합니다.
      if (match.Success)
      {
        Console.WriteLine($"Found a number: {match.Value}"); // 출력: Found a number: 100
      }
      else
      {
        Console.WriteLine("No match found.");
      }

      // 추가 설명:
      // - `\d`는 숫자 한 자리를 의미하며, `+`는 1회 이상 반복되는 패턴을 의미합니다.
      // - 따라서 `\d+` 패턴은 하나 이상의 연속된 숫자와 일치합니다.
      // - 정규 표현식은 복잡한 텍스트 검색 및 변환 작업을 간단하게 처리할 수 있는 매우 강력한 도구입니다.

      // 다른 예제: 여러 패턴을 활용한 정규 표현식
      string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
      string emailInput = "example@example.com";

      if (Regex.IsMatch(emailInput, emailPattern))
      {
        Console.WriteLine($"Valid email address: {emailInput}");
      }
      else
      {
        Console.WriteLine($"Invalid email address: {emailInput}");
      }
      // 위의 예제는 이메일 주소의 형식이 올바른지 확인하는 정규 표현식입니다.
      // 출력: Valid email address: example@example.com

      // 정규 표현식을 사용한 문자열 대체
      string replacePattern = @"\d";
      string replaceInput = "My phone number is 123-456-7890";
      string replaced = Regex.Replace(replaceInput, replacePattern, "*");

      Console.WriteLine($"Replaced string: {replaced}");
      // 출력: Replaced string: My phone number is ***-***-****

      // 이 예제는 숫자를 `*`로 대체하는 정규 표현식입니다.
    }
  }
}
