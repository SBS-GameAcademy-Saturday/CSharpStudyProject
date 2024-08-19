using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// 복사(값)와 참조
    /// 목표: 값 타입과 참조 타입의 차이를 이해하고, C#에서의 동작 방식을 학습한다.
    /// 값 타입(Value Type)은 데이터를 직접 저장하며, 참조 타입(Reference Type)은 데이터가 저장된 메모리의 주소를 저장한다.
    /// 이 클래스는 값 타입과 참조 타입의 차이를 보여주는 간단한 예제를 제공한다.
    /// 
    /// 복사와 참조 설명:
    /// 값 타입(Value Type): 
    /// 값 타입은 변수가 직접 데이터를 저장합니다. 
    /// 정수형(int), 부동 소수점(float, double), 구조체(struct) 등이 여기에 해당합니다. 
    /// 값 타입의 변수를 다른 변수에 할당하면, 데이터의 복사본이 생성되어 
    /// 서로 독립적인 메모리 공간에 저장됩니다. 
    /// 따라서, 하나의 변수를 변경해도 다른 변수에는 영향을 미치지 않습니다.
    /// 
    /// 참조 타입(Reference Type): 
    /// 참조 타입은 메모리 내의 객체나 데이터 구조를 가리키는 참조(주소)를 저장합니다. 
    /// 클래스(class), 배열(array), 인터페이스(interface) 등이 참조 타입에 속합니다. 
    /// 참조 타입의 변수를 다른 변수에 할당하면, 원본 데이터의 주소가 복사되므로 
    /// 두 변수는 같은 객체나 데이터 구조를 가리킵니다. 
    /// 이로 인해 한 변수를 통해 객체를 변경하면, 
    /// 다른 변수를 통해서도 변경된 상태를 볼 수 있습니다.
    /// 
    /// C# 프로그래밍에서 값 타입과 참조 타입의 이해는 데이터의 저장, 전달, 
    /// 복사 방식을 제어하는 데 중요합니다. 
    /// 각 타입의 특성을 이해하고 적절히 사용하는 것은 프로그램의 
    /// 효율성과 안정성을 보장하는 데 필수적입니다.
    /// 
    /// </summary>
    public class Class2
    {
        // 구조체 정의
        struct Point
        {
            public int X;
            public int Y;

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

        // 참조 타입 클래스 정의
        class Car
        {
            public string model;
            public void Drive()
            {
                Console.WriteLine(model + " is driving.");
            }
        }

        public void Run()
        {
            // 값 타입 예시
            int a = 10;
            int b = a; // 'a'의 값을 'b'에 복사한다. 'a'와 'b'는 독립적인 메모리 공간을 가진다.
            b = 20; // 'b'의 값을 변경해도 'a'에는 영향을 미치지 않는다.
            Console.WriteLine($"Value Type Example: a = {a}, b = {b}"); // 출력: a = 10, b = 20

            // 구조체 예시 (값 타입)
            Point p1 = new Point(1, 2);
            Point p2 = p1; // p1의 값을 p2에 복사한다. p1과 p2는 독립적인 메모리 공간을 가진다.
            p2.X = 5; // p2의 값을 변경해도 p1에는 영향을 미치지 않는다.
            Console.WriteLine("Struct Example:");
            p1.Display(); // 출력: Point(1, 2)
            p2.Display(); // 출력: Point(5, 2)

            // 참조 타입 예시
            Car car1 = new Car();
            car1.model = "Honda";
            Car car2 = car1; // 'car1'의 참조(주소)를 'car2'에 복사한다. 'car1'과 'car2'는 같은 객체를 가리킨다.
            car2.model = "Ford"; // 'car2'를 통해 객체의 'model'을 변경하면, 'car1'을 통해서도 변경된 값을 볼 수 있다.
            Console.WriteLine($"Reference Type Example: car1.model = {car1.model}, car2.model = {car2.model}"); // 출력: car1.model = Ford, car2.model = Ford
        }
    }
}
