using System;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
  /// <summary>
  /// 추상 클래스와 인터페이스
  /// 목표: 추상 클래스와 인터페이스의 개념을 이해하고, 객체 지향 프로그래밍에서의 역할을 학습한다.
  /// 
  /// 추상 클래스(Abstract Class)와 인터페이스(Interface) 설명:
  /// 
  /// 1. 추상 클래스(Abstract Class):
  ///    - 추상 클래스는 인스턴스화할 수 없는 클래스입니다. 
  ///    - 추상 클래스는 다른 클래스들이 상속받아야 할 기본적인 기능과 구조를 정의하는데 사용됩니다.
  ///    - 추상 클래스는 하나 이상의 추상 메서드(Abstract Method)를 포함할 수 있으며, 추상 메서드는 구현되지 않은 메서드입니다.
  ///    - 추상 메서드를 상속받은 자식 클래스는 반드시 이 메서드를 구현해야 합니다.
  ///    - 추상 클래스는 공통 기능을 공유하는 여러 클래스에서 코드 중복을 줄이고, 일관된 인터페이스를 제공하기 위해 사용됩니다.
  /// 
  /// 2. 인터페이스(Interface):
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
  /// 3. 추상 클래스와 인터페이스의 차이점:
  ///    - 추상 클래스는 일부 구현을 포함할 수 있지만, 인터페이스는 구현을 포함하지 않습니다.
  ///    - 한 클래스는 여러 인터페이스를 구현할 수 있지만, 오직 하나의 추상 클래스만 상속받을 수 있습니다.
  ///    - 추상 클래스는 클래스 간의 계층 구조를 나타내고, 인터페이스는 클래스 간의 계약을 나타냅니다.
  /// 
  /// 이 예제에서는 추상 클래스와 인터페이스를 정의하고, 이를 구현하는 클래스를 통해 두 개념의 차이점과 사용법을 학습합니다.
  /// </summary>
  public class Class11
  {
    /// <summary>
    /// 추상 클래스: Animal
    /// </summary>
    public abstract class Animal
    {
      // 추상 메서드: 모든 자식 클래스에서 구현해야 함
      public abstract void MakeSound();

      // 일반 메서드: 모든 자식 클래스에서 상속받을 수 있음
      public void Sleep()
      {
        Console.WriteLine("The animal is sleeping.");
      }
    }

    /// <summary>
    /// 인터페이스: IAnimalActions
    /// </summary>
    public interface IAnimalActions
    {
      void Eat();
      void Move();
    }

    /// <summary>
    /// Dog 클래스: Animal 추상 클래스를 상속받고, IAnimalActions 인터페이스를 구현
    /// </summary>
    public class Dog : Animal, IAnimalActions
    {
      // 추상 클래스의 추상 메서드를 구현
      public override void MakeSound()
      {
        Console.WriteLine("The dog barks: Woof woof!");
      }

      // 인터페이스의 메서드를 구현
      public void Eat()
      {
        Console.WriteLine("The dog is eating.");
      }

      public void Move()
      {
        Console.WriteLine("The dog is running.");
      }
    }

    public void Run()
    {
      // Dog 객체 생성 및 메서드 호출
      Dog myDog = new Dog();

      // 추상 클래스에서 상속받은 메서드 호출
      myDog.MakeSound(); // 출력: The dog barks: Woof woof!
      myDog.Sleep(); // 출력: The animal is sleeping.

      // 인터페이스에서 구현된 메서드 호출
      myDog.Eat(); // 출력: The dog is eating.
      myDog.Move(); // 출력: The dog is running.
    }
  }
}
