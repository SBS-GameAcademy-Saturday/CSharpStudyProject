using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 기본 산술 연산자의 사용과 연산 우선순위를 이해한다.
    /// 목표: 더하기, 빼기, 곱하기, 나누기 및 나머지 연산자의 사용법을 학습하고, 이들 연산의 우선순위를 이해한다.
    /// 내용:
    /// - 더하기(+), 빼기(-), 곱하기(*), 나누기(/)는 기본적인 산술 연산을 수행한다.
    /// - 나머지 연산(%)은 한 수를 다른 수로 나눈 후의 나머지를 반환한다.
    /// - 연산 우선순위는 괄호 > 곱하기/나누기/나머지 > 더하기/빼기 순으로 적용된다.
    /// 이 클래스는 기본 산술 연산자의 사용 예를 제공하며, 연산의 결과를 보여준다.
    /// 
    /// 산술 연산 설명:
    /// 더하기(+): 두 수를 더합니다.
    /// 빼기(-): 첫 번째 수에서 두 번째 수를 뺍니다.
    /// 곱하기(*): 두 수를 곱합니다.
    /// 나누기(/): 첫 번째 수를 두 번째 수로 나눕니다. 
    /// *정수끼리 나누기 연산을 할 경우, 결과는 정수로 반환되며 소수점 이하는 버려집니다. 
    /// *소수점 이하까지 결과를 얻고자 한다면, 연산에 참여하는 적어도 하나의 수를 실수(double 또는 float)로 변환해야 합니다.
    /// 
    /// 나머지(%): 첫 번째 수를 두 번째 수로 나눈 후의 나머지를 반환합니다.
    /// 연산 우선순위:
    /// 산술 연산 시, 연산자 간의 우선순위가 적용됩니다. 
    /// 우선순위는 괄호를 사용하여 명확하게 지정할 수 있으며, 
    /// 괄호가 없는 경우 기본적으로 곱하기, 나누기, 나머지 연산이 더하기와 빼기 연산보다 먼저 수행됩니다.
    /// 
    /// 산술 연산과 연산 우선순위의 이해는 프로그램에서 정확한 계산을 수행하고 
    /// 예상치 못한 결과를 방지하는 데 필수적입니다.
    /// </summary>
    public class Class_9
    {
        public void Run()
        {
            // 기본 산술 연산자 사용 예제
            int sum = 10 + 5; // 더하기
            int difference = 10 - 5; // 빼기
            int product = 10 * 5; // 곱하기
            double quotient = 10 / 3.0; // 나누기, 정확한 소수 결과를 얻기 위해 피연산자 중 하나를 double로 지정
            int remainder = 10 % 3; // 나머지

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            //결론
            // Sum: 15
            // Difference: 5
            // Product: 50
            // Quotient: 3.3333333333333335
            // Remainder: 1

            int result = 3 + 4 * 5; // 곱셈이 덧셈보다 우선순위가 높으므로, 4 * 5가 먼저 계산됩니다.
            Console.WriteLine(result); // 출력: 23

            int resultWithParentheses = (3 + 4) * 5; // 괄호를 사용하여 덧셈이 먼저 수행되도록 합니다.
            Console.WriteLine(resultWithParentheses); // 출력: 35

            // 논리 연산자의 우선순위
            bool logicResult = true || false && false; // &&가 ||보다 우선순위가 높습니다.
            Console.WriteLine(logicResult); // 출력: True

            int a = 10;
            a += 10;  // => a = a + 10;
            Console.WriteLine(a); // 20;
            a -= 5;  // => a = a - 5;
            Console.WriteLine(a);//15;
            a *= 2;  // => a = a * 2;
            Console.WriteLine(a);// 30;
            a /= 5; // => a = a / 5;
            Console.WriteLine(a);//6 
            
            //결론
            // 23
            // 35
            // True
        }

        // static void Main(string[] args)
        // {
        //     new Class_10().Run();
        // }
    }
}
