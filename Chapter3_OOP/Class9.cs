using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter3_OOP
{
    /// <summary>
    /// 다형성
    /// 목표: 메소드 오버라이딩을 통해 다형성을 구현하는 방법을 학습한다.
    /// 
    /// 다형성(Polymorphism)은 객체 지향 프로그래밍의 핵심 원칙 중 하나로, 
    /// "많은 형태를 가질 수 있는 능력"을 의미합니다. 
    /// 다형성은 같은 인터페이스나 메서드 호출이 서로 다른 객체 타입에 대해 서로 다른 동작을 할 수 있게 해줍니다. 
    /// 이를 통해 코드의 유연성과 재사용성을 높일 수 있습니다.
    /// 
    /// C#에서 다형성은 주로 메서드 오버라이딩(Method Overriding)을 통해 구현됩니다. 
    /// 메서드 오버라이딩은 상속 관계에 있는 클래스에서 부모 클래스에 정의된 메서드를 자식 클래스에서 재정의하는 것을 말합니다.
    /// 
    /// 메서드 오버라이딩(Method Overriding)
    /// virtual 메서드: 
    /// 부모 클래스에서 메서드를 정의할 때 virtual 키워드를 사용하면, 
    /// 이 메서드는 자식 클래스에서 오버라이드될 수 있습니다. 
    /// virtual 메서드는 기본적인 동작을 제공하며, 
    /// 필요에 따라 자식 클래스에서 변경할 수 있습니다.
    /// 
    /// override 메서드: 
    /// 자식 클래스에서 부모 클래스의 virtual 메서드를 재정의할 때 override 키워드를 사용합니다. 
    /// 이를 통해 메서드의 동작을 자식 클래스에 맞게 변경할 수 있습니다.
    /// 
    /// 다형성의 장점:
    /// 1, 코드의 유연성: 다형성을 사용하면 한 인터페이스로 다양한 객체의 메서드를 호출할 수 있어, 코드의 유연성이 증가합니다.
    /// 2, 재사용성 및 확장성: 기존 코드를 수정하지 않고도 새로운 클래스를 추가하거나 기존 클래스를 확장할 수 있어, 
    ///                         코드의 재사용성과 확장성이 높아집니다.                     
    /// 3, 유지 보수성: 코드의 중복을 줄이고, 변경에 대한 영향을 최소화하여 유지 보수성을 향상시킵니다.
    /// </summary>
    public class Class9
    {
        class Animal
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }
    }
}