using System;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
  public class Chapter2_Quiz
  {

    // 열거형 선언
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    /// <summary>
    /// 문제 1: 정수를 입력받아 홀수인지 짝수인지 판단하고, 짝수라면 요일을 출력하세요.
    /// - 사용자가 정수를 입력하면, if-else 조건문을 사용하여 그 숫자가 홀수인지 짝수인지를 판단합니다.
    /// - 짝수인 경우, switch 문과 enum을 사용하여 숫자를 7로 나눈 나머지를 기준으로 요일을 출력합니다.
    /// 정수를 입력하세요: 12
    /// 12은 짝수입니다.
    /// 오늘은 Saturday입니다.
    /// </summary>
    public void Quiz_1()
    {
      // 문제 1: 사용자 입력을 받아 홀수와 짝수를 판단하고, 짝수일 경우 요일 출력
      Console.WriteLine("문제 1: 정수를 입력받아 홀수인지 짝수인지 판단하고, 짝수라면 요일을 출력하세요.");

      Console.Write("정수를 입력하세요: ");
      int userInput = int.Parse(Console.ReadLine());

      if (userInput % 2 == 0)
      {
        Console.WriteLine($"{userInput}은 짝수입니다.");

        // 짝수인 경우, 요일을 선택하기 위한 switch 문
        Days today = (Days)(userInput % 7); // 입력된 숫자를 7로 나눈 나머지로 요일 결정
        Console.WriteLine($"오늘은 {today}입니다.");
      }
      else
      {
        Console.WriteLine($"{userInput}은 홀수입니다.");
      }
    }

    /// <summary>
    /// 문제 2: 2부터 9까지의 숫자 중 하나를 입력받아, 해당하는 구구단을 출력하세요.
    /// 구구단을 출력할 숫자를 입력하세요 (2-9): 7
    /// 구구단 7단:
    /// 7 x 1 = 7
    /// 7 x 2 = 14
    /// 7 x 3 = 21
    /// 7 x 4 = 28
    /// 7 x 5 = 35
    /// 7 x 6 = 42
    /// 7 x 7 = 49
    /// 7 x 8 = 56
    /// 7 x 9 = 63
    /// </summary>
    public void Quiz_2()
    {
      // 문제 2: 구구단 출력하기
      Console.WriteLine("문제 2: 2부터 9까지의 숫자 중 하나를 입력받아, 해당하는 구구단을 출력하세요.");

      Console.Write("구구단을 출력할 숫자를 입력하세요 (2-9): ");
      int dan = int.Parse(Console.ReadLine());

      if (dan < 2 || dan > 9)
      {
        Console.WriteLine("유효하지 않은 입력입니다. 2부터 9 사이의 숫자를 입력하세요.");
      }
      else
      {
        Console.WriteLine($"구구단 {dan}단:");
        for (int i = 1; i <= 9; i++)
        {
          Console.WriteLine($"{dan} x {i} = {dan * i}");
        }
      }
    }
  }
}
