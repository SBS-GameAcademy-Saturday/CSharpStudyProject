using System;

namespace CSharp_ProgramingStudy.Chapter5_Extension
{
    /// <summary>
    /// Lambda (람다식)
    /// 람다식은 C#에서 익명 함수를 생성하기 위한 간결한 방법을 제공합니다.
    /// 람다식은 매개변수 목록, => 연산자, 그리고 식 또는 문의 본문으로 구성됩니다.
    /// 이를 통해 이벤트 핸들러, LINQ 쿼리 등에서 사용할 수 있는 간단하고 강력한 방식으로 대리자 또는 식 트리를 정의할 수 있습니다.
    ///
    /// 주요 특징:
    /// - 익명성: 람다식은 이름이 없으며, 주로 메서드 인자로 전달하거나 변수에 할당하는 등의 방식으로 사용됩니다.
    /// - 간결성: 복잡한 함수를 한 줄의 코드로 간결하게 표현할 수 있으며, 코드의 가독성을 높입니다.
    /// - 유연성: 코드를 데이터와 같이 전달할 수 있어, 프로그래밍 패러다임을 유연하게 만들어 줍니다.
    ///
    /// 사용 예:
    /// 람다식은 (매개변수 목록) => 식 또는 (매개변수 목록) => { 문장들; } 형태를 가질 수 있습니다.
    /// 예를 들어, 두 수를 더하는 람다식: Func<int, int, int> add = (a, b) => a + b;
    /// 여기서 Func<int, int, int>는 두 개의 int 매개변수를 받고 int를 반환하는 대리자 타입입니다.
    ///
    /// 활용:
    /// - 람다식은 LINQ 쿼리, 이벤트 핸들러의 등록, 타이머의 콜백 함수 등 다양한 곳에서 활용됩니다.
    /// - 특히, LINQ 쿼리에서 람다식을 사용하면 컬렉션에 저장된 데이터를 처리하는 복잡한 쿼리를 간결하고 읽기 쉬운 코드로 작성할 수 있습니다.
    /// </summary>
    public class Class6
    {
        public void Run()
        {
            // 람다식을 사용한 함수 할당 및 호출 예제
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(5, 3)); // 출력: 8
        }
    }
}
