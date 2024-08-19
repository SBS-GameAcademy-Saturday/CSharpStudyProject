using System;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// do-while
    /// 목표: 적어도 한 번은 반복문을 실행한 후, 조건에 따라 반복을 계속할지 결정한다.
    /// 
    /// do-while 반복문의 기본 구조는 다음과 같습니다:
    /// 
    /// 1. do 키워드 다음에 중괄호 {} 안에 반복적으로 실행될 코드를 작성합니다.
    /// 
    /// 2. 코드 블록이 실행된 후, while 키워드 다음의 괄호 () 안에 조건을 명시합니다.
    /// 이 조건이 true인 동안 반복문이 다시 실행됩니다.
    ///
    /// 3. 조건이 false가 되면 반복문이 종료됩니다.
    ///
    /// do-while 반복문은 다음과 같은 상황에서 유용합니다:
    /// - 반복을 시작하기 전에 조건을 평가할 필요가 없을 때
    /// - 코드 블록을 최소한 한 번은 실행해야 할 때
    ///
    /// 예를 들어, 사용자가 올바른 입력을 제공할 때까지 입력을 계속 받는 경우에 유용합니다.
    /// 이 예제에서는 사용자가 "exit"를 입력할 때까지 계속해서 메시지를 출력하는 간단한 do-while 반복문을 구현합니다.
    /// </summary>
    public class Class6

    {
        public void Run()
        {
            string input;
            do
            {
                Console.WriteLine("Type 'exit' to stop the loop:");
                input = Console.ReadLine();
            }
            while (input != "exit");
            Console.WriteLine("You exited the loop.");
        }
    }
}
