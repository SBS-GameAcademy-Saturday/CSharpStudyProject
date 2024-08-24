using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Nullable (널러블)
    /// 널러블 타입은 C#에서 값 타입(Value Type) 변수가 null 값을 가질 수 있게 해주는 기능입니다.
    /// 기본적으로 값 타입은 null을 할당할 수 없습니다. 예를 들어, int, double, bool과 같은 타입은
    /// 기본적으로 null을 허용하지 않습니다. 널러블 타입은 이러한 제약을 해결하고, 값 타입 변수가
    /// null을 가질 수 있도록 해줍니다.
    ///
    /// 널러블 타입의 선언:
    /// 널러블 타입은 해당 타입 뒤에 ?를 붙여 선언합니다. 예를 들어, int?는 널러블 정수 타입을 의미합니다.
    ///
    /// 널러블 타입의 주요 속성 및 메서드:
    /// - HasValue: 변수에 값이 할당되어 있는지 여부를 나타내는 bool 값입니다. 값이 있으면 true, null이면 false를 반환합니다.
    /// - Value: 변수에 저장된 값을 반환합니다. HasValue가 false일 때 Value를 접근하면 InvalidOperationException 예외가 발생합니다.
    ///
    /// 널러블 타입의 사용 이유:
    /// - 데이터베이스와의 상호작용: 데이터베이스에서는 종종 값이 '없음' 또는 '알 수 없음'을 나타내기 위해 null을 사용합니다.
    ///   널러블 타입을 사용하면 데이터베이스의 null 값을 자연스럽게 처리할 수 있습니다.
    /// - 옵셔널 데이터 처리: 함수나 메서드의 결과가 '없음'을 의미할 수 있을 때 널러블 타입을 사용하여 이를 표현할 수 있습니다.
    /// </summary>
    public class Class10
    {
        public void Run()
        {
            // 널러블 타입의 선언 및 초기화
            int? nullableInt = null;
            double? nullableDouble = null;
            bool? nullableBool = null;

            // 널러블 타입의 예제
            int? num = null; // 널러블 정수 타입 선언 및 null로 초기화
            if (num.HasValue) // 값이 존재하는지 확인
            {
                Console.WriteLine(num.Value); // 값이 존재할 경우, 값을 출력
            }
            else
            {
                Console.WriteLine("num is null"); // 값이 null인 경우, 메시지 출력
            }

            // 값 할당 후 다시 확인
            num = 10; // num에 10 할당
            if (num.HasValue) // 값이 존재하는지 다시 확인
            {
                Console.WriteLine(num.Value); // 값이 존재하면 출력
            }
        }
    }
}