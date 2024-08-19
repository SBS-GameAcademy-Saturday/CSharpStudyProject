using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// 생성자와 소멸자
    /// 목표: 객체가 생성될 때 초기화 작업을 수행하는 생성자의 역할과 정의 방법을 이해한다.
    /// 
    /// 생성자(Constructor)와 소멸자(Destructor) 설명:
    /// 생성자(Constructor):
    /// 생성자는 클래스의 인스턴스(객체)가 생성될 때 자동으로 호출되는 특별한 메서드입니다. 
    /// 생성자의 주된 목적은 객체 초기화입니다. 
    /// 즉, 필드(속성)의 초기값을 설정하거나, 객체 생성 시 필요한 준비 작업을 수행합니다. 
    /// 생성자는 클래스 이름과 동일한 이름을 가지며, 반환 타입을 지정하지 않습니다.
    /// 
    /// 기본 생성자: 
    /// 파라미터가 없는 생성자를 기본 생성자라고 하며, 
    /// 사용자가 명시적으로 정의하지 않으면 컴파일러가 자동으로 제공합니다. 
    /// 하지만, 클래스에 어떠한 생성자도 명시적으로 정의되어 있다면, 
    /// 컴파일러는 기본 생성자를 추가하지 않습니다.
    /// 
    /// 파라미터가 있는 생성자: 
    /// 초기화할 데이터를 외부에서 받아 객체의 상태를 설정할 수 있습니다. 
    /// 이를 통해 객체 생성 시 다양한 초기 상태를 갖는 객체를 생성할 수 있습니다.
    /// 
    /// 소멸자(Destructor):
    /// 소멸자는 객체가 더 이상 필요 없어져 메모리에서 해제될 때 자동으로 호출되는 메서드입니다. 
    /// 소멸자는 주로 객체가 사용한 리소스를 정리하는 데 사용됩니다(예: 파일 닫기, 네트워크 연결 해제). 
    /// C#에서는 가비지 컬렉터가 메모리 관리를 담당하기 때문에, 소멸자를 직접 작성할 필요가 적습니다. 
    /// 소멸자는 클래스 이름 앞에 ~를 붙여 정의합니다.
    /// 
    /// </summary>
    public class Class6
    {
        class Car
        {
            // Car 클래스의 속성
            public string color;

            /// <summary>
            /// Car 클래스의 생성자
            /// 파라미터가 있는 생성자를 통해 객체 생성 시 초기 색상을 설정한다.
            /// </summary>
            /// <param name="initialColor">차량의 초기 색상</param>
            public Car(string initialColor)
            {
                color = initialColor; // 객체의 color 속성을 초기화
            }

            /// <summary>
            /// Car 클래스의 소멸자
            /// 객체가 메모리에서 해제될 때 호출되어 리소스를 정리한다.
            /// </summary>
            ~Car()
            {
                // 필요한 리소스 정리 로직을 여기에 작성
                // 예: 파일 닫기, 네트워크 연결 해제 등
            }
        }

        public void Run()
        {
            // 'blue' 색상으로 Car 객체를 생성
            Car myCar = new Car("blue");
            Console.WriteLine(myCar.color); // 출력: blue
        }
    }
}