using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// 배열
    /// 목표: 배열을 사용하여 여러 데이터를 한 변수에 순서대로 저장하는 방법을 이해한다.
    /// 
    /// 배열(Array)은 같은 타입의 여러 데이터를 순서대로 저장하기 위한 데이터 구조입니다. 
    /// 배열을 사용하면 하나의 이름으로 여러 데이터를 관리할 수 있으며, 
    /// 인덱스를 사용하여 각 요소에 접근할 수 있습니다. 
    /// 배열은 고정된 크기를 가지며, 선언 시에 그 크기를 지정하거나 초기화할 데이터를 통해 크기가 결정됩니다.
    /// 배열의 특징:
    /// 1, 동일한 데이터 타입: 배열은 동일한 타입의 데이터만 저장할 수 있습니다. 
    /// 예를 들어, int[]는 정수형 데이터만, string[]는 문자열 데이터만 저장할 수 있습니다.
    /// 
    /// 2, 고정된 크기: 배열을 생성할 때 그 크기가 정해지며, 
    /// 이후에는 배열의 크기를 변경할 수 없습니다.
    /// 
    /// 3, 인덱스 접근: 배열의 각 요소는 0부터 시작하는 인덱스를 통해 접근할 수 있습니다. 
    /// 예를 들어, cars[0]은 cars 배열의 첫 번째 요소에 접근합니다.
    /// 
    /// 4, 순차적 메모리 할당: 배열의 요소들은 메모리 상에서 연속적으로 할당됩니다. 
    /// 이는 요소의 접근 속도를 높여줍니다.
    /// </summary>
    public class Class1
    {
        public void Run()
        {
            // 문자열 배열 선언 및 초기화
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]); // 출력: Volvo

            // 배열의 길이 출력
            Console.WriteLine(cars.Length); // 출력: 배열의 길이(요소의 수)

            // 배열 요소 순회
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
