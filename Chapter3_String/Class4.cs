using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// String Comparison (문자열 비교) 학습 자료
  /// 이 클래스는 C#에서 문자열을 비교할 때 자주 사용하는 주요 메서드들을 다룹니다.
  /// 학습할 메서드:
  /// - Equals: 두 문자열이 같은지 비교합니다.
  /// - Compare: 두 문자열을 비교하여 정렬 순서를 반환합니다.
  /// - CompareTo: 현재 인스턴스와 다른 문자열을 비교하여 정렬 순서를 반환합니다.
  /// </summary>
  public class Class4
  {
    public void Run()
    {
      // 1. Equals: 문자열이 같은지 비교합니다.
      string text1 = "Hello";
      string text2 = "hello";
      bool areEqual = text1.Equals(text2);
      bool areEqual2 = text1.Equals(text2, StringComparison.OrdinalIgnoreCase);// 대소문자 무시
      Console.WriteLine($"Equals 메서드로 비교: {areEqual}");// 출력 : False
      Console.WriteLine($"Equals 메서드로 비교 (대소문자 무시): {areEqual2}"); // 출력: True

      // 2. Compare: 두 문자열을 비교하여 정렬 순서를 반환합니다.
      string text3 = "apple";
      string text4 = "banana";
      int compareResult = string.Compare(text3, text4);
      Console.WriteLine($"Compare 메서드로 비교: {compareResult}"); // 출력: -1 (text3이 text4보다 작음)

      // 3. CompareTo: 현재 인스턴스와 다른 문자열을 비교하여 정렬 순서를 반환합니다.
      string text5 = "apple";
      string text6 = "banana";
      int compareToResult = text5.CompareTo(text6);
      Console.WriteLine($"CompareTo 메서드로 비교: {compareToResult}"); // 출력: -1 (text5가 text6보다 작음)
    }
  }
}
