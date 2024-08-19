using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Generic (일반화)
    /// 목표: 다양한 데이터 타입에 대해 동작할 수 있는 유연한 메소드나 클래스를 생성하는 방법을 이해한다.
    /// 
    /// Generic(일반화) 프로그래밍은 C#을 비롯한 많은 현대 프로그래밍 언어에서 지원하는 기능으로, 
    /// 코드의 재사용성, 타입 안정성, 성능을 향상시키기 위해 사용됩니다. 
    /// 제네릭을 사용하면 다양한 데이터 타입에 대해 동작할 수 있는 유연한 메서드나 클래스를 생성할 수 있습니다. 
    /// 이를 통해 특정 데이터 타입에 국한되지 않는 코드를 작성할 수 있어, 코드의 범용성과 재사용성이 증가합니다.
    /// 
    /// 설명:
    /// - 제네릭(Generic) 프로그래밍은 다양한 데이터 타입을 처리할 수 있는 메서드나 클래스를 작성할 수 있게 해주는 기능입니다. 
    /// 이를 통해 특정 데이터 타입에 국한되지 않는 범용적인 코드를 작성할 수 있습니다.
    /// - C#에서 제네릭을 사용하면, 코드의 재사용성을 높이고, 컴파일 시 타입 안정성을 보장하며, 성능을 향상시킬 수 있습니다.
    /// 
    /// 제네릭의 주요 장점:
    /// 1, 타입 안정성(Type Safety): 제네릭을 사용하면 컴파일 시간에 타입을 체크할 수 있어, 
    /// 런타임 오류를 줄일 수 있습니다. 이는 타입 캐스팅이나 타입 검사를 줄여줌으로써 타입 관련 오류의 가능성을 낮춥니다.
    /// 2, 코드 재사용성(Reusability): 한 번 제네릭으로 정의된 클래스나 메서드는 다양한 타입에 대해 재사용할 수 있습니다. 
    /// 이는 코드 중복을 줄이고, 유지 보수를 용이하게 합니다.
    /// 3, 성능 향상(Performance): 제네릭을 사용하면 박싱(Boxing)과 언박싱(Unboxing)과정이 필요 없어, 성능이 향상됩니다. 
    /// 특히 값 타입(Value Type)을 사용할 때 이점이 큽니다.
    /// 
    /// 제네릭의 사용 예:
    /// 제네릭은 클래스, 인터페이스, 메서드, 델리게이트 등 다양한 곳에서 사용할 수 있습니다.
    /// <T>, <T, U>와 같은 형태로 타입 파라미터를 표현합니다. T는 타입을 의미하며, 
    /// 필요에 따라 여러 개의 타입 파라미터를 사용할 수 있습니다.
    /// 
    /// 제네릭 클래스 (Generic Classes)
    /// 설명: 제네릭 클래스는 여러 타입에 대해 동일한 동작을 수행할 수 있는 클래스를 정의하는 방법입니다. 
    /// 클래스의 정의에서 타입 파라미터를 사용하여 클래스가 여러 타입과 함께 작동할 수 있도록 합니다.
    /// 
    /// 제네릭 메서드 (Generic Methods)
    /// 설명: 제네릭 메서드는 메서드 단위에서 특정 타입에 독립적인 로직을 구현할 수 있는 방법입니다. 
    /// 메서드 내에서 제네릭 타입을 사용하여 다양한 데이터 타입을 처리할 수 있습니다.
    /// 
    /// 
    /// </summary>
    public class Class1
    {
        public class GenericList<T>
        {
            private List<T> _list = new List<T>();

            public void Add(T input)
            {
                _list.Add(input);
            }

            public T Get(int index)
            {
                return _list[index];
            }
        }

        // 제네릭 메서드 정의
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        public static void Run()
        {
            // 제네릭 클래스 사용 예
            GenericList<int> intList = new GenericList<int>();
            intList.Add(10);
            intList.Add(20);
            Console.WriteLine($"First element: {intList.Get(0)}");

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine($"First element: {stringList.Get(0)}");

            Print<string>("Hello World");
            Print<int>(1);
        }

    }
}