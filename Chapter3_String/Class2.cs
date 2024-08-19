using System;

namespace CSharp_ProgramingStudy.Chapter3_String
{
    /// <summary>
    /// 파싱
    /// 목표: 문자열 데이터를 다른 데이터 타입으로 변환하는 파싱 방법을 학습한다.
    /// 내용:
    /// - 문자열을 숫자 타입으로 변환: 일반적으로 사용자 입력이나 파일, 네트워크 소스로부터
    ///   읽은 데이터는 문자열 형태이며, 이를 숫자 타입(int, double 등)으로 변환해야 할 때가 많다.
    ///  
    /// 이 클래스는 문자열 데이터를 다른 데이터 타입으로 안전하게 변환하는 두 가지 주요 방법인 파싱과 TryParse 사용의 예를 보여준다.
    /// 
    /// 파싱 설명:
    /// 문자열을 숫자 타입으로 변환하기: 프로그램에서 사용자로부터 입력받은 문자열이나 외부 데이터 소스에서 읽어온 문자열을
    /// 숫자와 같은 다른 데이터 타입으로 변환해야 할 필요가 자주 있다.
    /// 
    /// - Parse 메소드: 문자열을 특정 타입으로 강제 변환한다. 변환할 수 없는 문자열인 경우 예외를 발생시킨다.
    /// - TryParse 메소드: 변환에 실패할 경우 예외를 발생시키지 않고, 변환 성공 여부를 bool 타입으로 반환한다.
    /// 
    /// Parse 설명:
    /// Parse 메소드는 문자열을 숫자 타입(int, double 등)으로 변환할 때 사용합니다. 
    /// 이 메소드는 변환할 수 없는 문자열에 대해서는 FormatException 예외를 발생시키기 때문에,
    /// 사용할 문자열의 형식이 올바른지 확실한 경우에 사용하는 것이 좋습니다.
    /// 
    /// TryParse 설명:
    /// TryParse 메소드는 변환을 시도하고, 변환에 실패해도 예외를 발생시키지 않으며, 변환 성공 여부를 bool 값으로 반환합니다.
    /// 변환에 성공하면 변환된 값을 out 파라미터를 통해 얻을 수 있습니다. 이 메소드는 변환을 시도하는 과정에서 발생할 수 있는
    /// 예외를 방지하기 위해 사용됩니다.
    /// 
    /// 파싱은 프로그래밍에서 흔히 발생하는 작업 중 하나이며, 문자열 데이터를 다른 타입으로 변환할 때 정확하게 이해하고 적용하는 것이 중요하다.
    /// TryParse 메소드를 적절히 사용함으로써 프로그램의 안정성을 높일 수 있다.
    /// </summary>
    public class Class2
    {
        public void Run()
        {
            // 문자열을 int 타입으로 파싱 예제
            string intString = "123";
            int parsedInt = int.Parse(intString);
            Console.WriteLine($"Parse로 변환된 int 값: {parsedInt}");

            // 잘못된 문자열을 int로 변환 시도
            string invalidIntString = "123abc";
            try
            {
                int invalidParsedInt = int.Parse(invalidIntString);
                Console.WriteLine($"Parse로 변환된 잘못된 int 값: {invalidParsedInt}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"'{invalidIntString}'은 int로 파싱할 수 없습니다.");
            }

            // 문자열을 double 타입으로 파싱 예제
            string doubleString = "123.45";
            double parsedDouble;
            bool isDoubleParseSuccessful = double.TryParse(doubleString, out parsedDouble);
            Console.WriteLine(isDoubleParseSuccessful ? $"TryParse로 파싱된 double 값: {parsedDouble}" : "double로 파싱 실패");

            // 잘못된 문자열을 double로 변환 시도
            string invalidDoubleString = "abc123.45";
            double invalidParsedDouble;
            bool isInvalidDoubleParseSuccessful = double.TryParse(invalidDoubleString, out invalidParsedDouble);
            Console.WriteLine(isInvalidDoubleParseSuccessful ? $"TryParse로 파싱된 잘못된 double 값: {invalidParsedDouble}" : $"'{invalidDoubleString}'은 double로 파싱할 수 없습니다.");

            // 문자열을 DateTime 타입으로 파싱 예제
            string dateString = "2024-01-01";
            DateTime parsedDate;
            bool isDateParseSuccessful = DateTime.TryParse(dateString, out parsedDate);
            Console.WriteLine(isDateParseSuccessful ? $"TryParse로 파싱된 DateTime 값: {parsedDate.ToShortDateString()}" : "DateTime으로 파싱 실패");

            // 잘못된 문자열을 DateTime으로 변환 시도
            string invalidDateString = "not a date";
            DateTime invalidParsedDate;
            bool isInvalidDateParseSuccessful = DateTime.TryParse(invalidDateString, out invalidParsedDate);
            Console.WriteLine(isInvalidDateParseSuccessful ? $"TryParse로 파싱된 잘못된 DateTime 값: {invalidParsedDate}" : $"'{invalidDateString}'은 DateTime으로 파싱할 수 없습니다.");
        }
    }
}
