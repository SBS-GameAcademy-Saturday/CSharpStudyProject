
using System;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// Struct (구조체)
    /// 목표: 구조체를 사용하여 값 타입 데이터를 그룹화하고 관리하는 방법을 이해한다.
    ///
    /// 구조체(Struct)는 값 타입(Value Type) 데이터를 묶어 하나의 논리적인 단위로 표현할 수 있는 데이터 구조입니다.
    /// 클래스와 유사한 형태를 가지며, 주로 작은 데이터 그룹을 표현하는 데 사용됩니다.
    /// C#에서 구조체는 System.ValueType을 상속받으며, 스택(Stack) 메모리에 저장됩니다.
    ///
    /// 주요 특징:
    /// 1. 값 타입: 구조체는 값 타입이므로 인스턴스가 직접 데이터를 저장합니다. 변수 간 복사 시 데이터를 복사합니다.
    /// 2. 불변성(Immutability): 구조체는 가능한 불변하게(immutable) 설계하는 것이 좋습니다. 이는 구조체가 주로 작은 데이터 묶음으로 사용되며,
    ///    값이 자주 변하지 않는 경우에 최적화된 성능을 제공하기 때문입니다.
    /// 3. 상속 불가: 구조체는 다른 클래스나 구조체를 상속받을 수 없으며, 다른 타입을 상속할 수 없습니다. 하지만 인터페이스는 구현할 수 있습니다.
    /// 4. 매개변수 없는 생성자 없음: 구조체는 기본적으로 매개변수가 없는 생성자를 가질 수 없습니다. 생성자는 반드시 모든 필드를 초기화해야 합니다.
    ///
    /// 사용 예:
    /// 구조체는 작은 데이터 집합(예: 좌표, 색상, 복소수 등)을 표현할 때 주로 사용됩니다. 또한, 값 타입으로 스택에 저장되므로,
    /// 클래스보다 더 빠른 성능을 제공할 수 있습니다. 그러나 크기가 큰 데이터나 자주 변경되는 데이터를 표현할 때는 클래스가 더 적합할 수 있습니다.
    /// </summary>
    public class Class2
    {
        // 2D 좌표를 나타내는 구조체 정의
        public struct Point
        {
            public int X { get; } // X 좌표
            public int Y { get; } // Y 좌표

            // 생성자를 통해 좌표 초기화
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // 두 점 간의 거리를 계산하는 메서드
            public double DistanceTo(Point other)
            {
                int dx = X - other.X;
                int dy = Y - other.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public void Run()
        {
            // Point 구조체의 인스턴스 생성
            Point p1 = new Point(0, 0); // 원점 (0, 0)
            Point p2 = new Point(3, 4); // (3, 4) 위치

            // 두 점 사이의 거리 계산
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between p1 and p2: {distance}"); // 출력: 5
        }
    }
}
