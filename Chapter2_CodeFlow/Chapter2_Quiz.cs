using System;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
  public class Chapter2_Quiz
  {
      // 연습 문제
      // 영화표 가격 계산기
      // 2. 기본 변수 설정
      // 기본 요금(basePrice): 15,000원
      // - 나이(age): 정수형
      // - 평일 여부(isWeekday) : 불리언(true: 평일, false: 주말)
      // - 멤버십 여부(isMember): 불리언(true: 회원, false: 비회원)

      // 3. 할인 및 할증 조건 (논리/비교 연산자 활용)
      // 다음 조건들을 순서대로 적용하여 최종 가격을 계산하세요.
      // - 나이가 5세 미만이면 티켓 가격은 0원입니다.
      // 나이 제한 및 무료 입장:
      // - 나이가 19세 미만인 '청소년'은 기본 요금에서 3,000원을 할인합니다.
      // 주말 할증:
      // - 평일이 아닌 경우(주말인 경우), 기본 요금에 2,000원이 추가됩니다.
      // 특별 할인 (중복 가능):
      // - 조조 할인: 평일(isWeekday)이면서 나이가 65세 이상인 경우 추가로 2,000원을 할인합니다.
      // - 멤버십 할인: 멤버십 회원(isMember)이거나, 현재 결제 금액이 13,000원 이상인 경우 최종 금액에서 2,000원를 할인합니다.
      // 1. 변수 초기화
      int _basePrice = 15000;
      int age = 25;           // 테스트용 나이
      bool _isWeekday = true; // 테스트용 요일 (true: 평일)
      bool _isMember = false; // 테스트용 멤버십
      
      int _finalPrice = _basePrice;
      
      // 2. 주말 할증 (평일이 아닌 경우)
      // ! 연산자를 사용하여 '평일이 아님'을 판별합니다.
      if (!_isWeekday)
      {
          _finalPrice += 2000;
      }
      
      // 3. 나이 제한 및 무료 입장
      if (age < 5)
      {
          _finalPrice = 0;
      }
      else if (age < 19)
      {
          // 청소년 할인
          _finalPrice -= 3000;
      }
      
      // 4. 특별 할인 (중복 가능하므로 else if가 아닌 if문 사용)
      
      // 조조 할인: 평일이면서 65세 이상 (&& 연산자)
      if (_isWeekday && age >= 65)
      {
          _finalPrice -= 2000;
      }
      
      // 멤버십 할인: 멤버십 회원이거나 결제 금액이 13,000원 이상 (|| 연산자)
      // 5세 미만 무료 입장객 등이 0원이 된 경우를 고려하여 조건 체크
      if (_finalPrice > 0 && (_isMember || _finalPrice >= 13000))
      {
          _finalPrice -= 2000;
      }
      
      // 최종 결과 출력 (가격이 음수가 되지 않도록 방어 코드 추가)
      if (_finalPrice < 0) _finalPrice = 0;
      
      Console.WriteLine($"최종 영화 티켓 가격: {_finalPrice}원");

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
