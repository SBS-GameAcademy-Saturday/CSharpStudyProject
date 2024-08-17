using System;
using System.Text;

namespace Chapter3_String
{
  /// <summary>
  /// 문자열 인코딩과 디코딩 (String Encoding and Decoding) 학습 자료
  /// 
  /// 문자열 데이터를 특정 인코딩(예: UTF-8, ASCII)으로 변환하거나,
  /// 인코딩된 데이터를 문자열로 변환하는 방법을 학습합니다.
  /// 문자열 인코딩은 텍스트 데이터를 바이트 배열로 변환하여 전송하거나 저장할 때 사용됩니다.
  /// 디코딩은 바이트 배열로 인코딩된 데이터를 다시 문자열로 변환하는 과정입니다.
  /// </summary>
  public class Class10
  {
    public void Run()
    {
      // 문자열을 UTF-8로 인코딩하는 예제
      string originalString = "Hello, World!";
      byte[] utf8Bytes = Encoding.UTF8.GetBytes(originalString);

      // 인코딩된 바이트 배열을 다시 문자열로 디코딩하는 예제
      string utf8String = Encoding.UTF8.GetString(utf8Bytes);

      // 결과 출력
      Console.WriteLine("Original String: " + originalString);  // 출력: Hello, World!
      Console.WriteLine("UTF-8 Encoded Bytes: " + BitConverter.ToString(utf8Bytes));
      Console.WriteLine("Decoded String: " + utf8String);  // 출력: Hello, World!

      // 추가 설명:
      // - Encoding.UTF8.GetBytes: 문자열을 UTF-8 형식으로 인코딩하여 바이트 배열로 변환합니다.
      // - Encoding.UTF8.GetString: UTF-8로 인코딩된 바이트 배열을 다시 문자열로 디코딩합니다.
      // - 인코딩은 데이터를 전송하거나 저장할 때, 다양한 시스템 간에 일관된 데이터 표현을 위해 필요합니다.
      // - 디코딩은 인코딩된 데이터를 원래의 문자열 형식으로 복원하는 과정입니다.

      // ASCII 인코딩 및 디코딩 예제
      byte[] asciiBytes = Encoding.ASCII.GetBytes(originalString);
      string asciiString = Encoding.ASCII.GetString(asciiBytes);

      Console.WriteLine("ASCII Encoded Bytes: " + BitConverter.ToString(asciiBytes));
      Console.WriteLine("Decoded ASCII String: " + asciiString);  // 출력: Hello, World!

      // 추가 설명:
      // - ASCII 인코딩은 7비트 인코딩을 사용하여 영어 알파벳과 숫자, 몇몇 특수 문자를 표현합니다.
      // - UTF-8은 유니코드를 기반으로 하며, 전 세계의 모든 문자를 표현할 수 있습니다.
      // - ASCII는 주로 영어 텍스트에 사용되며, UTF-8은 다양한 언어를 지원하는 범용 인코딩 방식입니다.

      // 바이트 배열의 내용을 16진수 문자열로 출력하는 방법
      Console.WriteLine("UTF-8 Encoded Bytes (Hex): " + BitConverter.ToString(utf8Bytes));
      Console.WriteLine("ASCII Encoded Bytes (Hex): " + BitConverter.ToString(asciiBytes));

      // 인코딩된 바이트를 다른 인코딩으로 디코딩할 경우 발생하는 문제
      string incorrectDecodedString = Encoding.UTF7.GetString(utf8Bytes);
      Console.WriteLine("Incorrect Decoded String (using UTF-7): " + incorrectDecodedString);
      // 출력: 다른 인코딩으로 디코딩하면 예상치 못한 결과가 나올 수 있습니다.
    }
  }
}
