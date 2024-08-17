using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_Extension
{
    /// <summary>
    /// Interface (인터페이스)
    /// 목표: 인터페이스를 사용하여 클래스에 특정 메소드를 구현하도록 강제하는 방법을 학습한다.
    /// 
    /// 인터페이스(Interface)는 C#에서 특정 클래스나 구조체가 구현해야 하는 
    /// 메서드의 시그니처(이름, 반환 타입, 매개 변수)를 정의하는 계약 같은 것입니다. 
    /// 인터페이스를 사용하면 다양한 클래스들이 동일한 인터페이스를 구현함으로써 
    /// 동일한 동작을 보장할 수 있으며, 이는 다형성(polymorphism)을 지원하는 중요한 메커니즘입니다.
    /// 
    /// 인터페이스의 주요 특징:
    /// 1, 메서드 시그니처만 정의: 
    /// 인터페이스는 메서드의 구현을 포함하지 않고, 
    /// 메서드 시그니처(이름, 파라미터 타입 및 순서, 반환 타입)만을 정의합니다.
    /// 
    /// 2, 구현 강제: 
    /// 클래스나 구조체가 인터페이스를 구현하기로 선언하면, 
    /// 해당 인터페이스에 정의된 모든 메서드를 구현해야 합니다. 
    /// 이를 통해 일관된 동작을 강제할 수 있습니다.
    /// 
    /// 3, 다중 상속 지원: 
    /// C#에서 클래스는 단일 상속만 지원하지만, 
    /// 인터페이스를 통해 다중 상속과 유사한 효과를 낼 수 있습니다. 
    /// 클래스는 여러 인터페이스를 구현할 수 있습니다.
    /// 
    /// 4, 타입 안정성: 
    /// 인터페이스는 타입 체크 시 사용될 수 있어, 
    /// 인터페이스 타입으로 선언된 객체는 해당 인터페이스를 구현하는 
    /// 모든 클래스의 인스턴스를 참조할 수 있습니다.
    /// 
    /// 인터페이스의 활용:
    /// - 인터페이스는 다음과 같은 상황에서 유용하게 사용됩니다:
    /// - 여러 클래스가 동일한 메서드를 구현하도록 강제하고 싶을 때
    /// - 서로 다른 클래스의 객체를 동일한 방식으로 처리해야 할 때(다형성)
    /// - 클래스의 특정 기능만을 외부에 노출시키고 싶을 때
    ///
    /// </summary>
    public class Class2
    {
        interface IAnimal
        {
            void animalSound(); // 인터페이스 메서드
        }

        class Pig : IAnimal
        {
            public void animalSound()
            {
                // IAnimal 인터페이스의 animalSound 메서드 구현
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Pig, IAnimal
        {
            public void animalSound()
            {
                // IAnimal 인터페이스의 animalSound 메서드 구현
                Console.WriteLine("The dog says: bow wow");
            }
        }
    }
}