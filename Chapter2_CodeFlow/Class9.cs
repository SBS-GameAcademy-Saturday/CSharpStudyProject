using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// for - 이중 반복문 (Nested Loop)
    /// 목표: 두 개의 for 반복문을 중첩하여 사용하여 행과 열을 제어하고 패턴을 출력하는 방법을 이해합니다.
    ///
    /// 이중 반복문은 반복문 안에 또 다른 반복문이 포함된 구조입니다.
    /// 이것은 2차원적인 데이터(테이블, 격자, 배열 등)를 처리하거나,
    /// 행과 열의 구조를 가진 패턴(별찍기)을 출력할 때 필수적으로 사용됩니다.
    ///
    /// 1. 바깥쪽 반복문 (Outer Loop): 행(Row)을 제어합니다.
    ///    - 전체 몇 줄을 출력할지 결정합니다. (예: 5줄)
    ///
    /// 2. 안쪽 반복문 (Inner Loop): 열(Column)을 제어하며, 바깥쪽 반복문의 반복 횟수만큼 실행됩니다.
    ///    - 각 줄에서 어떤 내용(별, 숫자, 공백 등)을 몇 개 출력할지 결정합니다.
    ///
    /// [Image of Nested for loop structure flow diagram]
    ///
    /// 실행 순서의 이해가 중요합니다:
    /// - 바깥쪽 i가 한 번 증가할 때마다, 안쪽 j는 처음부터 끝까지 반복 실행됩니다.
    /// - 안쪽 반복문이 완전히 끝난 후, 바깥쪽 반복문으로 돌아가 줄바꿈이 실행됩니다.
    /// </summary>
    public class Class8
    {
        public void Run()
        {
            // N을 5로 설정하여 5x5 직각 삼각형을 그립니다.
            int N = 5; 
            Console.WriteLine($"--- N={N} 직각 삼각형 별찍기 ---");

            // 1. 바깥쪽 반복문 (행 제어): i는 1부터 N까지 1씩 증가하며, 총 N번 반복합니다.
            for (int i = 1; i <= N; i++)
            {
                // 안쪽 반복문이 시작될 때마다, 새로운 행을 출력할 준비를 합니다.

                // 2. 안쪽 반복문 (열 제어): j는 1부터 i까지 반복합니다.
                //    - i가 1일 때 j는 1번만 실행 (별 1개)
                //    - i가 2일 때 j는 2번 실행 (별 2개)
                //    - ...
                //    - i가 N일 때 j는 N번 실행 (별 N개)
                for (int j = 1; j <= i; j++)
                {
                    // Console.Write()를 사용하여 줄바꿈 없이 별(*)을 출력합니다.
                    Console.Write("*"); 
                }

                // 3. 안쪽 반복문이 끝난 후 (해당 행의 별 출력이 완료된 후)
                //    Console.WriteLine()을 사용하여 줄바꿈을 실행하여 다음 행으로 넘어갑니다.
                Console.WriteLine();
            }
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("응용: 바깥쪽 i가 1씩 증가할 때, 안쪽 j는 1부터 i까지 실행되면서 별의 개수가 늘어납니다.");
        }
    }
}
