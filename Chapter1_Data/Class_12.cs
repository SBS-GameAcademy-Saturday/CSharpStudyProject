using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
  /// <summary>
  /// 증감 연산자 (Increment and Decrement Operators)
  /// 목표: 증감 연산자를 사용하여 변수의 값을 증가시키거나 감소시키는 방법을 이해한다.
  /// 
  /// 증감 연산자는 변수의 값을 1만큼 증가 또는 감소시키는 연산자입니다. 
  /// 증감 연산자는 주로 반복문이나 특정 조건에서 값을 조작할 때 사용됩니다.
  ///
  /// 주요 연산자:
  /// - ++ : 1만큼 증가 (Increment)
  /// - -- : 1만큼 감소 (Decrement)
  /// 
  /// 증감 연산자의 위치에 따른 동작:
  /// 1. 전위 연산 (Prefix): 연산자가 변수 앞에 위치할 경우, 변수가 사용되기 전에 값을 증가/감소시킵니다.
  /// 2. 후위 연산 (Postfix): 연산자가 변수 뒤에 위치할 경우, 변수가 사용된 후에 값을 증가/감소시킵니다.
  ///
  /// 전위와 후위의 차이를 이해하는 것이 중요한데, 이 차이는 코드의 동작 결과에 영향을 미칠 수 있습니다.
  /// </summary>
  public class Class12
  {
    public void Run()
    {
            int number1 = 5;
            int number2 = 5;
            // 전위 증감 연산자: 먼저 값을 증가시킨 후 사용
            // 후위 증감 연산자: 값을 먼저 사용하고 그 후에 증가시킴
            Console.WriteLine($"증가 연산 [전위 : {++number1}] ,[후위 : {number2++}]");  // 출력: 증가 연산 [전위 : 6] ,[후위 : 5]
            Console.WriteLine($"증가 연산 후 값: {number1} , {number2}");         // 출력: 증가 연산 후 값: 6 , 6

            // 전위 감소 연산자: 먼저 값을 감소시킨 후 사용
            // 후위 감소 연산자: 값을 먼저 사용하고 그 후에 감소시킴
            Console.WriteLine($"감소 연산 [전위 : {--number1}] ,[후위 : {number2--}]");  // 출력: 감소 연산 [전위 : 5] ,[후위 : 6]
            Console.WriteLine($"감소 연산 후 값: {number1} , {number2}");  // 출력: 감소 연산 후 값: 5 , 5
    }
  }
}
