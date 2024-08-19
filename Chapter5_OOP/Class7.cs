using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// 상속성
    /// 목표: 클래스 간의 상속을 통해 코드의 재사용성을 높이는 방법을 이해한다.
    /// 
    /// 상속성(Inheritance)은 객체 지향 프로그래밍의 핵심 원칙 중 하나로, 
    /// 한 클래스(부모 클래스 또는 슈퍼 클래스라고 함)의 속성과 메서드를 
    /// 다른 클래스(자식 클래스 또는 서브 클래스라고 함)가 상속받아 사용할 수 있게 하는 메커니즘입니다. 
    /// 상속을 통해 코드의 재사용성을 높이고, 유지 보수를 용이하게 하며, 
    /// 프로그램의 계층적 구조를 명확하게 할 수 있습니다.
    /// 
    /// 상속성의 특징:
    /// 1, 코드 재사용: 상속을 통해 기존 클래스의 기능을 확장하거나 수정할 필요 없이 새로운 클래스에서 이를 사용할 수 있습니다. 
    /// 이로 인해 코드 중복을 줄이고 재사용성을 높일 수 있습니다.
    /// 
    /// 2, 계층적 분류: 상속을 사용하면 관련 있는 클래스들을 계층적으로 분류하여 관리할 수 있습니다. 
    /// 이는 프로그램의 구조를 이해하기 쉽게 만들어 줍니다.
    /// 
    /// 3, 다형성 구현: 상속은 다형성(Polymorphism)을 구현하는 데 중요한 역할을 합니다. 
    /// 자식 클래스는 부모 클래스로부터 상속받은 메서드를 오버라이드(재정의)하여 사용할 수 있으며, 
    /// 이를 통해 다양한 형태의 객체를 동일한 인터페이스로 다룰 수 있습니다.
    /// 
    /// </summary>
    public class Class7
    {
        // Vehicle 클래스: 모든 차량의 기본이 되는 클래스
        class Vehicle
        {
            public string brand = "Ford"; // 차량 브랜드
            public void honk() // 경적 소리 메서드
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }

        // Car 클래스: Vehicle 클래스를 상속받는 서브 클래스
        class Car : Vehicle
        {
            public string modelName = "Mustang"; // Car 클래스만의 속성
        }

        public void Run()
        {
            Car myCar = new Car(); // Car 인스턴스 생성
            myCar.honk(); // 부모 클래스의 메서드 호출
            Console.WriteLine(myCar.brand + " " + myCar.modelName); // 출력: Ford Mustang
        }
    }
}