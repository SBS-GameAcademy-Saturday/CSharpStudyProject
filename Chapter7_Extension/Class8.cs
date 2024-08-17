using System;
using System.Reflection;

namespace CSharp_ProgramingStudy.Chapter5_Extension
{
    /// <summary>
    /// Reflection (리플렉션)
    /// 리플렉션은 실행 시간에 프로그램의 메타 데이터를 검사하고, 조작할 수 있는 강력한 기능을 제공합니다.
    /// C#에서 리플렉션은 System.Reflection 네임스페이스를 통해 사용할 수 있으며,
    /// 클래스의 타입 정보를 얻거나, 인스턴스를 동적으로 생성하고, 메서드를 호출하거나,
    /// 프로퍼티와 필드에 접근할 수 있게 해줍니다.
    ///
    /// 주요 사용 사례:
    /// - 타입 정보 얻기: 실행 시간에 객체의 타입을 얻거나, 해당 타입이 가지고 있는 메서드, 프로퍼티, 필드, 이벤트 등의 정보를 조회할 수 있습니다.
    /// - 동적 인스턴스 생성: Activator.CreateInstance 메서드를 사용하여 실행 시간에 동적으로 객체 인스턴스를 생성할 수 있습니다.
    /// - 메서드 실행: 리플렉션을 사용하여 특정 객체의 메서드를 동적으로 호출할 수 있습니다.
    /// - 어트리뷰트 접근: 클래스, 메서드, 프로퍼티 등에 적용된 어트리뷰트 정보를 읽어올 수 있습니다.
    /// - 프로퍼티와 필드 조작: 실행 시간에 객체의 프로퍼티나 필드에 값을 설정하거나, 값을 가져올 수 있습니다.
    ///
    /// 리플렉션의 장단점:
    /// - 장점: 동적 프로그래밍이 가능하며, 프로그램의 유연성과 확장성을 높일 수 있습니다.
    /// - 단점: 성능 오버헤드가 발생할 수 있으며, 타입 안전성이 보장되지 않을 수 있습니다. 내부 구현을 쉽게 노출할 수 있어 보안상의 문제가 될 수 있습니다.
    /// 리플렉션은 프로그램의 동적인 조작이 필요할 때 매우 유용하지만, 성능과 보안 측면에서 신중하게 사용해야 합니다.
    /// </summary>
    public class Class8
    {
        class MyClass
        {
            public void Method1() { Console.WriteLine("Method1 실행"); }
            public void Method2() { Console.WriteLine("Method2 실행"); }
        }
        public void Run()
        {
            Type type = typeof(MyClass);
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine("Method name: " + method.Name);
            }

            // MyClass의 인스턴스 생성 및 메서드 호출 예제
            MyClass myClassInstance = (MyClass)Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod("Method1");
            methodInfo.Invoke(myClassInstance, null);
            //출력 
            // Method name: Method1
            // Method name: Method2
            // Method name: GetType
            // Method name: ToString
            // Method name: Equals
            // Method name: GetHashCode
            // Method1 실행
        }
    }
}
