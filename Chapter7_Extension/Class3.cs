using System;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Property (프로퍼티)
    /// 목표: 프로퍼티를 사용하여 클래스의 멤버 변수에 대한 접근을 제어하는 방법을 이해한다.
    /// 
    /// 프로퍼티(Property)는 C#에서 클래스의 멤버 변수(필드)에 대한 접근을 제어하는 방법을 제공합니다. 
    /// 프로퍼티를 사용하면 필드에 대한 읽기와 쓰기 접근을 캡슐화하여, 
    /// 필드 값에 대한 유효성 검사 또는 다른 로직을 실행할 수 있게 해주며, 
    /// 직접 필드에 접근하는 것보다 더 안전한 방법을 제공합니다.
    /// 
    /// 프로퍼티의 주요 특징:
    /// 1, 캡슐화(Encapsulation): 
    /// 필드를 직접적으로 노출시키지 않고 프로퍼티를 통해 접근을 제어함으로써, 
    /// 객체의 상태를 보호하고 유효성 검사나 추가 로직 실행이 가능합니다.
    /// 
    /// 2, 읽기 전용(Read-Only) 및 쓰기 전용(Write-Only) 프로퍼티: 
    /// 프로퍼티는 get 접근자와 set 접근자를 통해 읽기와 쓰기 가능성을 제어할 수 있습니다. 
    /// get만 제공하면 읽기 전용, set만 제공하면 쓰기 전용 프로퍼티가 됩니다.
    /// 
    /// 3, 자동 구현 프로퍼티(Auto-Implemented Properties): 
    /// 구현 로직이 필요 없는 경우, C#은 필드를 선언하지 않고도 
    /// 프로퍼티를 간결하게 작성할 수 있는 자동 구현 프로퍼티를 제공합니다.
    /// 
    /// 4, 데이터 바인딩(Data Binding): 
    /// 프로퍼티는 UI 프로그래밍에서 데이터 바인딩을 위해 널리 사용됩니다. 
    /// 객체의 프로퍼티가 변경될 때 UI 요소가 자동으로 업데이트될 수 있게 해줍니다.
    /// </summary>
    public class Class3
    {
        class Person
        {
            private string name; // private 필드

            // public 프로퍼티
            public string Name
            {
                get { return name; } // 읽기 접근자
                set { name = value; } // 쓰기 접근자
            }
        }

        class Person2
        {
            // 자동 구현 프로퍼티
            public string Name { get; set; } 
        }

        public void Run()
        {
            // Person 클래스 사용 예
            Person person1 = new Person();
            person1.Name = "John"; // set 접근자를 통해 이름 설정
            Console.WriteLine(person1.Name); // get 접근자를 통해 이름 읽기

            // Person2 클래스 사용 예
            Person2 person2 = new Person2();
            person2.Name = "Alice"; // 자동 구현 프로퍼티를 통해 이름 설정 및 읽기
            Console.WriteLine(person2.Name);
        }
    }
}
