using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// 스택과 힙
    /// 목표: 스택과 힙 메모리 영역의 차이점과 각각에서 데이터가 어떻게 관리되는지 이해한다.
    /// 설명: 스택은 컴파일 시간에 크기가 결정되는 값 타입 데이터를 저장하고, 힙은 런타임에 할당되는 참조 타입 데이터를 저장한다.
    /// 스택 메모리 영역:
    /// - 스택은 자동으로 할당되고 해제되는 지역 변수를 저장하는 LIFO(Last In, First Out) 구조의 메모리 영역입니다.
    /// - 스택은 메서드 호출 시 메서드에 대한 지역 변수와 매개변수를 저장합니다.
    /// - 스택 메모리는 컴파일 시간에 크기가 결정되며, 주로 값 타입의 데이터(int, double, bool 등)를 저장합니다.
    /// - 스택은 빠른 액세스 속도를 제공하며, 자동 메모리 관리의 이점이 있습니다.
    /// - 하지만, 스택의 크기는 제한적이므로, 너무 많은 메모리 사용 시 스택 오버플로우가 발생할 수 있습니다.
    /// 
    /// 힙 메모리 영역:
    /// - 힙은 런타임에 동적으로 할당되는 메모리 영역으로, 참조 타입의 데이터(예: 클래스 인스턴스)를 저장합니다.
    /// - 힙에 저장된 데이터는 프로그래머가 직접 관리해야 하며, C#에서는 가비지 컬렉터가 메모리 관리를 돕습니다.
    /// - 힙은 유연한 메모리 관리를 가능하게 하지만, 스택에 비해 상대적으로 느린 액세스 속도와 메모리 해제에 대한 책임이 있습니다.
    /// 
    /// 스택과 힙의 이해는 메모리 관리와 프로그램 성능 최적화에 매우 중요합니다. 각 메모리 영역의 특성을 고려하여
    /// 적절한 데이터 타입을 선택하고, 효율적인 메모리 사용 전략을 수립하는 것이 권장됩니다.
    /// </summary>
    public class Class4
    {
        /// <summary>
        /// 구조체 예제: 스택에 할당되는 값 타입의 예시
        /// </summary>
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Display()
            {
                Console.WriteLine($"Point({X}, {Y})");
            }
        }

        /// <summary>
        /// Car 클래스: 힙에 할당되는 참조 타입의 예시
        /// </summary>
        class Car
        {
            public string Model { get; set; }
        }

        /// <summary>
        /// 스택 메모리 예제: 값 타입 변수의 복사와 독립성
        /// </summary>
        private void StackExample()
        {
            int value1 = 10; // 스택에 저장된 지역 변수
            int value2 = value1; // 스택에 복사본이 생성됨
            value2 = 20; // value2의 값을 변경해도 value1에 영향을 미치지 않음
            Console.WriteLine($"StackExample: value1 = {value1}"); // 출력: 10

            // 구조체 사용 예제
            Point p1 = new Point(1, 2); // 스택에 저장된 구조체
            Point p2 = p1; // 구조체의 복사본이 스택에 생성됨
            p2.X = 5; // p2의 값을 변경해도 p1에는 영향을 미치지 않음
            Console.WriteLine("Struct Example:");
            p1.Display(); // 출력: Point(1, 2)
            p2.Display(); // 출력: Point(5, 2)
        }

        /// <summary>
        /// 힙 메모리 예제: 참조 타입 변수의 복사와 객체 공유
        /// </summary>
        private void HeapExample()
        {
            var car1 = new Car { Model = "Honda" }; // 힙에 저장된 객체
            var car2 = car1; // car1의 참조(주소)를 car2에 복사
            car2.Model = "Ford"; // car2를 통해 객체의 Model을 변경하면 car1을 통해서도 변경된 상태를 볼 수 있음
            Console.WriteLine($"HeapExample: car1.Model = {car1.Model}"); // 출력: Ford
        }

        public void Run()
        {
            // 스택 사용 예제
            StackExample();

            // 힙 사용 예제
            HeapExample();
        }
    }
}
