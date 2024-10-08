using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 캐스팅
    /// 목표: 데이터 타입 간의 변환을 이해하고 캐스팅 방법을 학습한다.
    /// 내용:
    /// - 암시적 캐스팅: 변환되는 데이터 타입이 원본 데이터 타입보다 더 큰 범위를 가지거나, 
    /// 더 많은 정보를 저장할 수 있을 때 발생한다. 데이터 손실이 없는 안전한 변환이다.
    /// 
    /// - 명시적 캐스팅: 변환되는 데이터 타입이 원본 데이터 타입보다 더 작은 범위를 가지거나, 
    /// 더 적은 정보만을 저장할 수 있을 때 사용한다. 데이터 손실이 발생할 수 있으므로, 
    /// 개발자가 변환을 명시적으로 지시해야 한다.
    /// 
    /// 이 클래스는 데이터 타입 간 변환의 두 가지 주요 방법인 암시적과 명시적 캐스팅의 예를 보여준다.
    /// 
    /// 캐스팅 설명:
    /// 암시적 캐스팅(Implicit Casting): 암시적 캐스팅은 소스 타입이 대상 타입보다 작을 때 발생합니다. 
    /// 이는 컴파일러에 의해 자동으로 수행되며, 데이터 손실의 위험이 없습니다. 
    /// 예를 들어, int를 double로 변환하는 경우가 이에 해당합니다.
    /// 
    /// 명시적 캐스팅(Explicit Casting): 명시적 캐스팅은 대상 타입이 소스 타입보다 작을 때 필요합니다. 
    /// 이 경우, 변환을 위해 캐스팅 연산자를 사용해야 하며, 데이터 손실이 발생할 수 있습니다. 
    /// 예를 들어, double에서 int로 변환할 때 소수점 이하의 값이 손실됩니다.
    /// 
    /// 캐스팅은 프로그래밍에서 자주 발생하는 작업 중 하나이며, 
    /// 데이터 타입 간의 안전한 변환을 보장하기 위해 이러한 규칙을 정확히 이해하고 적용하는 것이 중요합니다. 
    /// 데이터 손실을 피하기 위해 적절한 캐스팅 방법을 선택하는 것은 개발자의 책임입니다.
    /// </summary>
    public class Class_8
    
    {
        public void Run()
        {
            // 암시적 캐스팅 예제 (int에서 double로)
            int myInt = 9;
            double myDouble = myInt; // 여기서는 데이터 손실이 없다.

            // 명시적 캐스팅 예제 (double에서 int로)
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // 소수점 이하 값은 손실된다.

            Console.WriteLine($"암시적 캐스팅 결과: {myDouble}");
            Console.WriteLine($"명시적 캐스팅 결과: {myInt2}");
        }
    }
}
