using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// String Methods 학습 자료
  /// 이 클래스는 C#에서 문자열을 조작할 때 자주 사용하는 주요 메서드들을 다룹니다.
  /// 학습할 메서드:
  /// - Length: 문자열의 길이를 반환합니다.
  /// - Substring: 문자열의 일부를 추출합니다.
  /// - IndexOf: 특정 문자의 첫 번째 위치를 찾습니다.
  /// - ToUpper / ToLower: 문자열을 대문자 또는 소문자로 변환합니다.
  /// - Trim: 문자열의 앞뒤 공백을 제거합니다.
  /// - Replace: 특정 문자열을 다른 문자열로 교체합니다.
  /// - Split: 문자열을 특정 구분자를 기준으로 나누어 배열로 반환합니다.
  /// </summary>
  public class Class3
  {
    public void Run()
    {
      // 1. Length: 문자열의 길이를 반환합니다.
      string text = "Hello, World!";
      int length = text.Length;
      Console.WriteLine($"문자열의 길이: {length}"); // 출력: 문자열의 길이: 13

      // 2. Substring: 문자열의 일부를 추출합니다.
      string subText = text.Substring(7, 5);
      Console.WriteLine($"추출된 문자열: {subText}"); // 출력: 추출된 문자열: World

      // 3. IndexOf: 특정 문자의 첫 번째 위치를 찾습니다.
      int index = text.IndexOf('W');
      Console.WriteLine($"'W'의 위치: {index}"); // 출력: 'W'의 위치: 7

      // 4. ToUpper / ToLower: 문자열을 대문자 또는 소문자로 변환합니다.
      string upperText = text.ToUpper();
      string lowerText = text.ToLower();
      Console.WriteLine($"대문자 변환: {upperText}"); // 출력: 대문자 변환: HELLO, WORLD!
      Console.WriteLine($"소문자 변환: {lowerText}"); // 출력: 소문자 변환: hello, world!

      // 5. Trim: 문자열의 앞뒤 공백을 제거합니다.
      string textWithSpaces = "   Hello, World!   ";
      string trimmedText = textWithSpaces.Trim();
      Console.WriteLine($"공백 제거: '{trimmedText}'"); // 출력: 공백 제거: 'Hello, World!'

      // 6. Replace: 특정 문자열을 다른 문자열로 교체합니다.
      string replacedText = text.Replace("World", "CSharp");
      Console.WriteLine($"교체된 문자열: {replacedText}"); // 출력: 교체된 문자열: Hello, CSharp!

      // 7. Split: 문자열을 특정 구분자를 기준으로 나누어 배열로 반환합니다.
      string fruitText = "Apple,Banana,Cherry";
      string[] fruits = fruitText.Split(',');
      Console.WriteLine("Split 결과:");
      foreach (string fruit in fruits)
      {
        Console.WriteLine(fruit);
      }
      // 출력:
      // Apple
      // Banana
      // Cherry
    }
  }
}
