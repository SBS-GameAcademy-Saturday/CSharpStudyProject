using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// while
    /// 목표: 조건이 참인 동안 반복 실행하는 반복문을 사용한다.
    /// 
    /// while 반복문의 기본 구조는 다음과 같습니다:
    /// 
    /// 1, while 키워드 다음에 괄호 () 안에 반복 조건을 명시합니다. 
    /// 이 조건이 true인 동안 반복문 내의 코드 블록이 실행됩니다.
    ///
    /// 2, 중괄호 {} 안에는 조건이 참일 때 반복적으로 실행될 코드를 작성합니다.
    ///
    /// 3, 반복문을 탈출하기 위해, 반복문 내에서 조건이 
    /// false가 될 수 있도록 하는 로직을 포함시켜야 합니다. 
    /// 이 예제에서는 count++를 사용하여 count의 값을 증가시킵니다.
    /// 
    /// while 반복문은 다음과 같은 상황에서 특히 유용합니다:
    /// 반복 횟수가 미리 정해져 있지 않은 경우
    /// 특정 조건이 만족되기를 기다리는 동안 계속해서 실행해야 하는 경우
    /// 파일의 끝에 도달할 때까지 데이터를 읽거나, 
    /// 사용자가 특정 입력을 할 때까지 기다리는 등의 작업을 할 때
    /// 
    /// 이러한 while 반복문의 사용은 프로그램의 흐름을 제어하고, 
    /// 필요에 따라 동일한 작업을 반복적으로 수행하는 데 필수적인 도구입니다. 
    /// 여러분도 이 예제를 직접 실행해보고, 
    /// 다양한 조건과 상황에서 while 반복문을 활용해 보세요.
    /// </summary>
    public class Class5
    {
        public void Run()
        {
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }
        }
    }
}