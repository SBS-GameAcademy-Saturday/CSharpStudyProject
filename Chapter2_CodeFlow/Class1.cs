using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// if와 else
    /// 목표: 조건에 따라 코드 실행을 분기하는 방법을 이해한다.
    /// 조건문을 사용하여 특정 조건이 참인 경우와 거짓인 경우에 대한 처리를 구분한다.
    /// 이 클래스는 정수 변수의 값이 양수인지를 평가하고, 그 결과에 따라 다른 메시지를 출력한다.
    /// 
    /// 조건문 설명:
    /// if 문: if 문은 주어진 조건이 true일 때 실행될 코드 블록을 정의합니다. 
    /// 조건은 괄호 () 안에 위치하며, 이 조건이 참일 경우에만 
    /// 중괄호 {} 안에 있는 코드가 실행됩니다.
    /// 
    /// else 문: if 문에 이어 사용되며, 
    /// if 문의 조건이 false일 때 실행될 코드 블록을 정의합니다.
    /// else 문은 선택적으로 사용할 수 있으며, if 문의 조건이 거짓일 경우에 
    /// 대한 대안적인 실행 경로를 제공합니다.
    /// 
    /// 조건문은 프로그램에서 결정을 내리고, 
    /// 다양한 조건에 따라 다른 동작을 수행하도록 할 때 사용됩니다. 
    /// 예를 들어, 사용자 입력의 유효성 검사, 데이터의 범위 확인, 
    /// 프로그램의 실행 흐름 제어 등에 활용될 수 있습니다. 
    /// if와 else를 사용하는 조건문은 프로그래밍의 기본적인 구성 요소 중 하나이며, 
    /// 복잡한 조건과 중첩된 조건을 처리하는 데도 확장될 수 있습니다.
    /// 
    /// </summary>
    public class Class1
    {
        public void Run()
        {
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else
            {
                Console.WriteLine("Number is non-positive.");
            }
        }
    }
}