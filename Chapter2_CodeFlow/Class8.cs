using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// break, continue
    /// 
    /// 먼저, break 키워드에 대해 알아보겠습니다. 
    /// break는 반복문을 즉시 종료하고 반복문 다음의 코드 실행을 계속하도록 합니다. 
    /// 이 예제에서는 i가 5에 도달했을 때 break가 실행되어 for 반복문을 종료하고 있습니다. 
    /// break는 반복문을 제어하는 데 유용하게 사용될 수 있으며, 
    /// 특정 조건 하에서 더 이상 반복을 계속할 필요가 없을 때 사용됩니다.
    /// 
    /// 다음으로, continue 키워드는 현재 반복을 즉시 종료하고 
    /// 반복문의 다음 반복으로 넘어갑니다. 
    /// 이 예제에서는 i가 짝수일 경우, 즉 i % 2 == 0일 때 
    /// continue가 실행되어 Console.WriteLine(i); 코드를 건너뛰고 다음 반복을 진행합니다. 
    /// continue는 반복문 내에서 특정 조건을 만족하는 경우에 
    /// 현재 반복에서 더 이상의 코드 실행을 원하지 않을 때 유용하게 사용됩니다.
    /// 
    /// break와 continue는 반복문 내에서 프로그램의 흐름을 유연하게 
    /// 제어할 수 있게 해주는 강력한 도구입니다. 
    /// 이를 통해 반복문의 실행을 보다 정밀하게 관리할 수 있으며, 
    /// 코드의 가독성과 유지 보수성을 향상시킬 수 있습니다.
    /// </summary>
    public class Class8
    {
        public void Run()
        {
            // for 반복문에서 break와 continue 사용
            Console.WriteLine("Using break and continue in for loop:");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break; // i가 5일 때 반복문 종료
                if (i % 2 == 0) continue; // i가 짝수일 경우 출력 건너뛰기
                Console.WriteLine(i); // 홀수만 출력
            }

            // while 반복문에서 break와 continue 사용
            Console.WriteLine("\nUsing break and continue in while loop:");
            int count = 0;
            while (count < 10)
            {
                if (count == 7) break; // count가 7일 때 반복문 종료
                count++;
                if (count % 2 == 0) continue; // count가 짝수일 경우 건너뛰기
                Console.WriteLine(count); // 홀수만 출력
            }

            // do-while 반복문에서 break와 continue 사용
            Console.WriteLine("\nUsing break and continue in do-while loop:");
            int number = 0;
            do
            {
                if (number == 6) break; // number가 6일 때 반복문 종료
                number++;
                if (number % 2 == 0) continue; // number가 짝수일 경우 건너뛰기
                Console.WriteLine(number); // 홀수만 출력
            }
            while (number < 10);
        }
    }
}