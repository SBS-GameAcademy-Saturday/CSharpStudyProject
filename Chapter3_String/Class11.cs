using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
  /// <summary>
  /// 문자열 검색 및 대체 (Search and Replace) 학습 자료
  /// 
  /// 문자열 내에서 특정 패턴을 검색하거나 이를 다른 문자열로 대체하는 방법을 학습합니다.
  /// 문자열 검색은 특정 단어 또는 패턴이 문자열 내에서 존재하는지 확인하는 과정입니다.
  /// 문자열 대체는 특정 문자열이나 패턴을 다른 문자열로 교체하는 작업입니다.
  /// </summary>
  public class Class11
  {
    public void Run()
    {
      // 예제 1: 문자열 내에서 특정 단어 검색 및 대체
      string text = "The quick brown fox jumps over the lazy dog.";

      // "fox"를 "cat"으로 대체
      string replacedText = text.Replace("fox", "cat");

      // 결과 출력
      Console.WriteLine("Original Text: " + text);  // 출력: The quick brown fox jumps over the lazy dog.
      Console.WriteLine("Replaced Text: " + replacedText);  // 출력: The quick brown cat jumps over the lazy dog.

      // 추가 설명:
      // - `Replace` 메서드는 문자열 내의 특정 부분을 다른 문자열로 대체하는 데 사용됩니다.
      // - 이 메서드는 첫 번째 인수로 대체할 문자열을, 두 번째 인수로 새로운 문자열을 받습니다.
      // - 원본 문자열은 변경되지 않으며, 새로운 문자열이 반환됩니다.

      // 예제 2: 문자열 검색 및 대체 - 대소문자 구분
      string caseSensitiveText = "The Quick Brown Fox Jumps Over The Lazy Dog.";

      // "fox" (소문자)와 일치하는 부분이 없으므로, 원본 문자열이 반환됩니다.
      string caseSensitiveReplace = caseSensitiveText.Replace("fox", "cat");

      // "Fox" (대문자)와 일치하는 부분을 "cat"으로 대체
      string caseInsensitiveReplace = caseSensitiveText.Replace("Fox", "cat");

      // 결과 출력
      Console.WriteLine("Case Sensitive Replace: " + caseSensitiveReplace);  // 출력: The Quick Brown Fox Jumps Over The Lazy Dog.
      Console.WriteLine("Case Insensitive Replace: " + caseInsensitiveReplace);  // 출력: The Quick Brown cat Jumps Over The Lazy Dog.

      // 추가 설명:
      // - `Replace` 메서드는 기본적으로 대소문자를 구분합니다.
      // - 대소문자를 구분하지 않고 대체를 수행하려면 정규 표현식(Regular Expressions)을 사용할 수 있습니다.

      // 예제 3: 문자열 내에서 특정 단어의 존재 여부 확인
      string wordToFind = "lazy";
      bool containsWord = text.Contains(wordToFind);

      Console.WriteLine($"Does the text contain '{wordToFind}'? {containsWord}");  // 출력: Does the text contain 'lazy'? True

      // 추가 설명:
      // - `Contains` 메서드는 문자열 내에 특정 문자열이 포함되어 있는지를 확인하는 데 사용됩니다.
      // - 대소문자를 구분하며, 일치하는 부분이 있을 경우 `true`, 없을 경우 `false`를 반환합니다.
    }
  }
}
