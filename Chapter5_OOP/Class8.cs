using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter3_OOP
{
    /// <summary>
    /// 클래스 형식 변환
    /// 목표: 상속 관계에 있는 클래스 간의 형식 변환을 이해한다.
    /// 
    /// 클래스 형식 변환은 객체 지향 프로그래밍에서 상속 관계에 있는 클래스 간에 이루어지는 형 변환을 말합니다. 
    /// 이러한 변환을 통해, 하나의 객체를 다른 클래스 타입으로 취급할 수 있으며, 
    /// 이는 다형성(Polymorphism)의 중요한 부분을 이룹니다. 
    /// 클래스 형식 변환에는 주로 업캐스팅(Upcasting)과 다운캐스팅(Downcasting)이 있습니다.
    /// 
    /// 업캐스팅(Upcasting)
    /// 업캐스팅은 서브 클래스의 인스턴스를 슈퍼 클래스 타입으로 변환하는 것을 말합니다. 
    /// 이 변환은 항상 안전하며, 명시적으로 형 변환 연산자를 사용하지 않아도 자동으로 이루어집니다. 
    /// 업캐스팅을 통해, 서브 클래스 객체를 슈퍼 클래스의 참조로 사용할 수 있습니다.
    /// 
    /// 다운캐스팅(Downcasting)
    /// 다운캐스팅은 업캐스팅의 반대 과정으로, 
    /// 슈퍼 클래스 타입의 객체를 서브 클래스 타입으로 변환하는 것을 말합니다. 
    /// 이 변환은 명시적으로 형 변환 연산자를 사용해야 하며, 
    /// 변환하는 타입이 실제 객체의 타입과 호환되지 않으면 런타임에 오류가 발생할 수 있습니다. 
    /// 따라서, 다운캐스팅은 타입 호환성을 확인한 후에 수행해야 합니다.
    /// </summary>
    public class Class8
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

        public void Run()
        {
            // 업캐스팅 예시: Dog 객체를 Animal 타입으로 변환
            Dog dog = new Dog();
            Animal animal = dog; // 업캐스팅, 자동으로 이루어짐
            animal.Eat(); // 상속받은 메서드 호출 가능

            // 다운캐스팅 예시: Animal 타입을 Dog 타입으로 변환
            Animal animal2 = new Dog();
            Dog dog2 = (Dog)animal2; // 다운캐스팅, 명시적 형 변환 필요
            dog2.Bark(); // Dog 클래스의 메서드 호출 가능
        }
    }
}