using System;

namespace CSharp_ProgramingStudy.Chapter4_Methods
{
    /// <summary>
    /// 재귀 메서드 (Recursive Methods) 학습 자료
    /// 
    /// 목표: 자기 자신을 호출하는 메서드를 이해하고, 반복적인 작업이나 분할 정복 알고리즘에 활용하는 방법을 학습한다.
    /// 
    /// 재귀 메서드(Recursive Methods) 설명:
    /// 
    /// 1. 재귀 메서드란?
    ///    - 재귀 메서드는 메서드가 자기 자신을 다시 호출하는 방식으로 동작합니다.
    ///    - 주로 반복적인 작업을 처리하거나, 문제를 작은 부분으로 나누어 해결하는 분할 정복 알고리즘에 사용됩니다.
    /// 
    /// 2. 재귀 메서드의 기본 구조:
    ///    - 재귀 메서드는 반드시 종료 조건을 포함해야 합니다. 
    ///    - 종료 조건이 없다면 메서드가 무한히 호출되어 StackOverflowException이 발생할 수 있습니다.
    ///    - 재귀 호출이 종료 조건에 도달하면, 메서드는 재귀 호출된 순서의 반대로 종료됩니다.
    /// 
    /// 3. 재귀 메서드의 예제:
    ///    - 아래의 예제에서는 재귀 메서드를 사용하여 주어진 숫자의 팩토리얼을 계산하는 `Factorial` 메서드를 정의합니다.
    ///    - 팩토리얼(Factorial) 계산은 자연수 n에 대해 n! = n * (n-1) * (n-2) * ... * 1로 정의됩니다.
    /// </summary>
    public class Class6
    {
        /// <summary>
        /// 재귀 메서드를 사용하여 팩토리얼을 계산하는 메서드
        /// </summary>
        /// <param name="n">계산할 숫자</param>
        /// <returns>n의 팩토리얼 값</returns>
        public int Factorial(int n)
        {
            // 종료 조건: n이 1 이하인 경우 1을 반환
            if (n <= 1) return 1;
            
            // 재귀 호출: n과 (n-1)의 팩토리얼 값을 곱하여 반환
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// 피보나치 수열을 재귀적으로 계산하는 메서드
        /// </summary>
        /// <param name="n">계산할 피보나치 수열의 n번째 항</param>
        /// <returns>n번째 피보나치 수</returns>
        public int Fibonacci(int n)
        {
            // 종료 조건: n이 0 또는 1인 경우 그 값을 반환
            if (n == 0) return 0;
            if (n == 1) return 1;
            
            // 재귀 호출: n번째 피보나치 수는 (n-1)번째와 (n-2)번째 피보나치 수의 합
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// 재귀 메서드를 사용하는 예제 메서드
        /// </summary>
        public void Run()
        {
            // Factorial 메서드를 사용하여 5의 팩토리얼 계산
            int factorialOf5 = Factorial(5);
            Console.WriteLine($"5! = {factorialOf5}"); // 출력: 5! = 120

            // Fibonacci 메서드를 사용하여 피보나치 수열의 6번째 항 계산
            int fibonacciOf6 = Fibonacci(6);
            Console.WriteLine($"Fibonacci(6) = {fibonacciOf6}"); // 출력: Fibonacci(6) = 8
        }
    }
}
